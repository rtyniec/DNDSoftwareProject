using Caliburn.Micro;
using DNDDesktopUI.Library.Api;
using DNDDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDDesktopUI.ViewModels
{
    public class CharacterViewModel : Screen
    {
		ICharacterEndpoint _characterEndpoint;

		public CharacterViewModel(ICharacterEndpoint characterEndpoint)
		{
			_characterEndpoint = characterEndpoint;		
		}

		protected override async void OnViewLoaded(object view)//when the character view loads, do this below:
		{
			base.OnViewLoaded(view);
			await LoadCharacters();
		}

		private async Task LoadCharacters()
		{
			var characterList = await _characterEndpoint.GetAll();
			Characters = new BindingList<CharacterModel>(characterList);
		}

		private BindingList<CharacterModel> _characters;

		public BindingList<CharacterModel> Characters
		{
			get { return _characters; }
			set 
			{ 
				_characters = value;
				NotifyOfPropertyChange(() => Characters);
			}
		}


	}
}
