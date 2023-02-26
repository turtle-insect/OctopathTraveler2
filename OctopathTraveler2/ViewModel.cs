using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctopathTraveler2
{
	internal class ViewModel
	{
		public ObservableCollection<Character> Party { get; set; } = new ObservableCollection<Character>();
		public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

		public ViewModel()
		{
			SaveData save = SaveData.Instance();
			var addresses = save.FindAddress("SavePlayerCharacterData", 0);
			if (addresses.Count != 0)
			{
				foreach (var address in save.FindAddress("CharacterID", addresses[0]))
				{
					var character = new Character(address);
					//if (character.ID < 0 || character.ID > 8) continue;
					Party.Add(character);
				}
			}

			addresses = save.FindAddress("ItemList", 0);
			if (addresses.Count != 0)
			{
				foreach (var address in save.FindAddress("ItemId", addresses[0]))
				{
					var item = new Item(address);
					Items.Add(item);
				}
			}
		}
	}
}
