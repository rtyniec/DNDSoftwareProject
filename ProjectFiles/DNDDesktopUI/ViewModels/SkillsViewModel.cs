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
    class SkillsViewModel : Screen
    {
        private IEventAggregator _events;

        public SkillsViewModel(IEventAggregator events)
        {
            _events = events;
        }

        //Moves to Ability Scores   
        public void GoToPreviousScreen()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(StaticNumbers.ABILITY_SCORES));
        }

        //Moves to Bonds, Flaws, Ideals  
        public void GoToNextScreen()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(StaticNumbers.BONDS_FLAWS_IDEALS));
        }
    }
}
