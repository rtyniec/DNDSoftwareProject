using Caliburn.Micro;
using DNDDesktopUI;
using Dungeons_DragonsCharacterBuilder.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_DragonsCharacterBuilder.ViewModels
{
    class BondsFlawsIdealsViewModel : Screen
    {
        private IEventAggregator _events;

        public BondsFlawsIdealsViewModel(IEventAggregator events)
        {
            _events = events;
        }

        //Moves to Skills  
        public void GoToPreviousScreen()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(StaticMembers.SKILLS));
        }

        //Moves to Character Overview 
        public void GoToNextScreen()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(StaticMembers.OVERVIEW));
        }
    }
}
