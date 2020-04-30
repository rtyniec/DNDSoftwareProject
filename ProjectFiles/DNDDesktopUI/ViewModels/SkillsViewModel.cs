using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_DragonsCharacterBuilder.ViewModels
{
    class SkillsViewModel : Screen
    {
        private IEventAggregator _events;

        public SkillsViewModel(IEventAggregator events)
        {
            _events = events;
        }
    }
}
