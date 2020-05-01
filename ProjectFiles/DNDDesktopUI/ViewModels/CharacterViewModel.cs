using Caliburn.Micro;
using DNDDesktopUI.Library.Api;
using DNDDesktopUI.Library.Models;
using Dungeons_DragonsCharacterBuilder.EventModels;
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
		IEventAggregator _events;

		public CharacterViewModel(ICharacterEndpoint characterEndpoint, IEventAggregator events)
		{
			_characterEndpoint = characterEndpoint;
			_events = events;
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

		public void LoadCreateCharacter()
		{
			_events.PublishOnUIThread(new MoveViewsEventModel(StaticMembers.RACE_CHOICE));
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
