using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctopathTraveler2
{
	internal class GVAS
	{
		private Dictionary<String, UEProperty> mProperties = new Dictionary<String, UEProperty>();

		public UEProperty Key(String key)
		{
			if (!mProperties.ContainsKey(key)) return null;
			return mProperties[key];
		}

		public uint Read(uint address)
		{
			// length
			address -= 4;
			uint length = SaveData.Instance().ReadNumber(address, 4);
			// key
			address += 4;
			String key = SaveData.Instance().ReadText(address, length);

			address += length;
			length = SaveData.Instance().ReadNumber(address, 4);
			address += 4;
			String type = SaveData.Instance().ReadText(address, length);
			address += length;
			switch (type)
			{
				case "IntProperty":
					mProperties.Add(key, new UEProperty() { Address = address + 9, Size = 4 });
					address += 17;
					break;

				case "BoolProperty":
					mProperties.Add(key, new UEProperty() { Address = address + 10, Size = 1 });
					address += 17;
					break;

				case "ArrayProperty":
					address += 8;
					length = SaveData.Instance().ReadNumber(address, 4);
					address += 4;
					type = SaveData.Instance().ReadText(address, length);
					address += length + 1;
					uint count = SaveData.Instance().ReadNumber(address, 4);
					address += 4;

					uint size = 4;
					switch (type)
					{
						case "BoolProperty":
						case "ByteProperty":
							size = 1;
							break;
					}
					for (uint i = 0; i < count; i++)
					{
						mProperties.Add(key + "_" + i.ToString(), new UEProperty() { Address = address, Size = size });
						address += size;
					}
					address += size;
					break;

				default:
					address += 4;
					address += Read(address);
					break;
			}
			return address;
		}
	}
}
