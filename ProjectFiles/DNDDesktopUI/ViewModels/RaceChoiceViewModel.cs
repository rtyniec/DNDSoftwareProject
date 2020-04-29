using Caliburn.Micro;
using Dungeons_DragonsCharacterBuilder.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_DragonsCharacterBuilder.ViewModels
{
    class RaceChoiceViewModel : Screen
    {

        private IEventAggregator _events;

        public RaceChoiceViewModel(IEventAggregator events)
        {
            _events = events;
        }

        public void MoveToClassChoice()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(4));
        }

        public void MoveToTitleScreen()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(1));
        }
    }
}
