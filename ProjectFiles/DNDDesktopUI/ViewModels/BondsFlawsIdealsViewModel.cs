using Caliburn.Micro;
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
    }
}
