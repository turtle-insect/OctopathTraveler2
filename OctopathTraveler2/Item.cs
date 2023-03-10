using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctopathTraveler2
{
	internal class Item
	{
		private GVAS mGVAS;

		public Item(uint address)
		{
			mGVAS = new GVAS();

			for (int i = 0; i < 2; i++)
			{
				address = mGVAS.Read(address);
			}
		}

		public uint ID
		{
			get
			{
				UEProperty property = mGVAS.Key("ItemId");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("ItemId");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
			}
		}

		public uint Count
		{
			get
			{
				UEProperty property = mGVAS.Key("Num");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Num");
				Util.WriteNumber(property.Address, property.Size, value, 0, 99);
			}
		}
	}
}
