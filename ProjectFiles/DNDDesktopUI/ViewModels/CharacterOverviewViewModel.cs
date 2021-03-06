﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_DragonsCharacterBuilder.ViewModels
{
    class CharacterOverviewViewModel : Screen
    {
        private IEventAggregator _events;

        public CharacterOverviewViewModel(IEventAggregator events)
        {
            _events = events;
        }
    }
}
