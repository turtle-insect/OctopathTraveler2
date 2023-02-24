using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctopathTraveler2
{
	internal class Character : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		private GVAS mGVAS;

		public Character(uint address)
		{
			mGVAS = new GVAS();

			for (int i = 0; i < 9; i++)
			{
				address = mGVAS.Read(address);
			}
		}

		public uint ID
		{
			get
			{
				UEProperty property = mGVAS.Key("CharacterID");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
		}

		public uint Lv
		{
			get
			{
				UEProperty property = mGVAS.Key("Level");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Level");
				Util.WriteNumber(property.Address, property.Size, value, 1, 99);
			}
		}

		public uint Exp
		{
			get
			{
				UEProperty property = mGVAS.Key("Exp");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Exp");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999999);
			}
		}

		public uint RawHP
		{
			get
			{
				UEProperty property = mGVAS.Key("RawHP");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("RawHP");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint RawMP
		{
			get
			{
				UEProperty property = mGVAS.Key("RawMP");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("RawMP");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint RawPOT
		{
			get
			{
				UEProperty property = mGVAS.Key("RawPOT");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("RawPOT");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint FirstJob
		{
			get
			{
				UEProperty property = mGVAS.Key("FirstJobID");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("FirstJobID");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
			}
		}

		public uint SecondJob
		{
			get
			{
				UEProperty property = mGVAS.Key("SecondJobID");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("SecondJobID");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
			}
		}

		public uint JobPoint
		{
			get
			{
				UEProperty property = mGVAS.Key("JobPoint");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("JobPoint");
				Util.WriteNumber(property.Address, property.Size, value, 0, 99999);
			}
		}

		public uint HP
		{
			get
			{
				UEProperty property = mGVAS.Key("HP");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("HP");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint MP
		{
			get
			{
				UEProperty property = mGVAS.Key("MP");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("MP");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint BP
		{
			get
			{
				UEProperty property = mGVAS.Key("BP");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("BP");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint SP
		{
			get
			{
				UEProperty property = mGVAS.Key("SP");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("SP");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint ATK
		{
			get
			{
				UEProperty property = mGVAS.Key("ATK");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("ATK");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint DEF
		{
			get
			{
				UEProperty property = mGVAS.Key("DEF");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("DEF");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint MATK
		{
			get
			{
				UEProperty property = mGVAS.Key("MATK");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("MATK");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint MDEF
		{
			get
			{
				UEProperty property = mGVAS.Key("MDEF");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("MDEF");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint ACC
		{
			get
			{
				UEProperty property = mGVAS.Key("ACC");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("ACC");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint EVA
		{
			get
			{
				UEProperty property = mGVAS.Key("EVA");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("EVA");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint CON
		{
			get
			{
				UEProperty property = mGVAS.Key("CON");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("CON");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint AGI
		{
			get
			{
				UEProperty property = mGVAS.Key("AGI");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("AGI");
				Util.WriteNumber(property.Address, property.Size, value, 0, 9999);
			}
		}

		public uint Sword
		{
			get
			{
				UEProperty property = mGVAS.Key("Sword");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Sword");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Sword)));
			}
		}

		public uint Lance
		{
			get
			{
				UEProperty property = mGVAS.Key("Lance");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Lance");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Lance)));
			}
		}

		public uint Dagger
		{
			get
			{
				UEProperty property = mGVAS.Key("Dagger");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Dagger");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Dagger)));
			}
		}

		public uint Axe
		{
			get
			{
				UEProperty property = mGVAS.Key("Axe");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Axe");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Axe)));
			}
		}

		public uint Bow
		{
			get
			{
				UEProperty property = mGVAS.Key("Bow");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Bow");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bow)));
			}
		}

		public uint Rod
		{
			get
			{
				UEProperty property = mGVAS.Key("Rod");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Rod");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Rod)));
			}
		}

		public uint Shield
		{
			get
			{
				UEProperty property = mGVAS.Key("Shield");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Shield");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Shield)));
			}
		}

		public uint Head
		{
			get
			{
				UEProperty property = mGVAS.Key("Head");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Head");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Head)));
			}
		}

		public uint Body
		{
			get
			{
				UEProperty property = mGVAS.Key("Body");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Body");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Body)));
			}
		}

		public uint Accessory1
		{
			get
			{
				UEProperty property = mGVAS.Key("Accessory1");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Accessory1");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Accessory1)));
			}
		}

		public uint Accessory2
		{
			get
			{
				UEProperty property = mGVAS.Key("Accessory2");
				return SaveData.Instance().ReadNumber(property.Address, property.Size);
			}
			set
			{
				UEProperty property = mGVAS.Key("Accessory2");
				SaveData.Instance().WriteNumber(property.Address, property.Size, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Accessory2)));
			}
		}
	}
}
