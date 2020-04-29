using Caliburn.Micro;
using Dungeons_DragonsCharacterBuilder.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_DragonsCharacterBuilder.ViewModels
{
    class ClassChoiceViewModel : Screen
    {
        private IEventAggregator _events;

        public ClassChoiceViewModel(IEventAggregator events)
        {
            _events = events;
        }

        public void MoveToRaceChoice()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(3));
        }

        public void MoveToAbilityScoreRolling()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(5));
        }
    }
}
