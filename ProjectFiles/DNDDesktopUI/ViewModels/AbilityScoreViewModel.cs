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
    class AbilityScoreViewModel : Screen
    {
        private IEventAggregator _events;
        
        public AbilityScoreViewModel(IEventAggregator events)
        {
            _events = events;
        }
        
        //Properties 
        public String AbilityScoreName
        {
            get;
            set;
        } = "Ability Scores";

        public String AbilityScoreDescription 
        { 
            get; 
            set; 
        } = "Roll You Ability Scores";


        //Moves to Class Choice Screen 
        public void GoToPreviousScreen()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(StaticNumbers.CLASS_CHOICE));
        }

        //Moves to Skills Screen 
        public void GoToNextScreen()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(StaticNumbers.SKILLS));
        }
    }
}
