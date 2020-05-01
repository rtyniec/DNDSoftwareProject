using Caliburn.Micro;
using DNDDesktopUI.EventModels;
using Dungeons_DragonsCharacterBuilder.EventModels;
using Dungeons_DragonsCharacterBuilder.ViewModels;
using Dungeons_DragonsCharacterBuilder.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDDesktopUI.ViewModels
{//we are limited to having only one item active at a time due to the inherited Conductor class from Caliburn...
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>, IHandle<MoveViewsEventModel>//know to put only view model classes in this conductor //this will allow us to display one form
    {//okay, so we made a login view - how do we load it in?

        //create a holder
        
        private IEventAggregator _events;
        private CharacterViewModel _characterVM;
        private SimpleContainer _container;
        
        public ShellViewModel(IEventAggregator events, CharacterViewModel characterVM
            ,SimpleContainer container)
        {
            _container = container;
            _events = events;
            _characterVM = characterVM;
           

            _events.Subscribe(this);
            
            ActivateItem(_container.GetInstance<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)//calls the handle method when the login is successful
        {
            ActivateItem(_characterVM);
            
        }

        /*
         * This handles the moving between views. 
         */
        public void Handle(MoveViewsEventModel message)
        {
            switch (message._viewNum)
            {
                case StaticMembers.TITLE_SCREEN:
                    break;
                case StaticMembers.CHAR_LIST:
                    break;
                case StaticMembers.RACE_CHOICE:
                    ActivateItem(new RaceChoiceViewModel(_events));
                    break;
                case StaticMembers.CLASS_CHOICE:
                    ActivateItem(new ClassChoiceViewModel(_events));
                    break;
                case StaticMembers.ABILITY_SCORES:
                    ActivateItem(new AbilityScoreViewModel(_events));
                    break;
                case StaticMembers.SKILLS:
                    ActivateItem(new SkillsViewModel(_events));
                    break;
                case StaticMembers.BONDS_FLAWS_IDEALS:
                    ActivateItem(new BondsFlawsIdealsViewModel(_events));
                    break;
                case StaticMembers.OVERVIEW:
                    ActivateItem(new CharacterOverviewViewModel(_events));
                    break;
                default:
                    break;
            }
            
        }

        public void LoadListCharacter()
        {
            ActivateItem(new ListCharacterViewModel());//lets create a new instance of this.
        }

        public void LoadShowCharacter()
        {
            ActivateItem(new ShowCharacterViewModel());
        }
    }
}
