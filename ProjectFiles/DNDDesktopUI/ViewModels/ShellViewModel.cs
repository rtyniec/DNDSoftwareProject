using Caliburn.Micro;
using DNDDesktopUI.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDDesktopUI.ViewModels
{//we are limited to having only one item active at a time due to the inherited Conductor class from Caliburn...
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>//know to put only view model classes in this conductor //this will allow us to display one form
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
