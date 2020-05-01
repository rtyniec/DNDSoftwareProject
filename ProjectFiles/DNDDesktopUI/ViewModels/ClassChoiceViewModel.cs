using Caliburn.Micro;
using DNDDesktopUI;
using Dungeons_DragonsCharacterBuilder.EventModels;
using Dungeons_DragonsCharacterBuilder.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

        /*
         * Activities of this View 
         */
         public void BarbarianButton()
         {
            
         }




        public void MoveToRaceChoice()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(StaticMembers.RACE_CHOICE));
        }

        public void MoveToAbilityScoreRolling()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(StaticMembers.ABILITY_SCORES));
        }
    }
}
