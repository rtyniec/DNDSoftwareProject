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
        public String AlignmentInfo { get; set; } = "Pick a Alignment";
        public String BackgroundInfo { get; set; } = "Pick a Background";

        private IEventAggregator _events;

        public BondsFlawsIdealsViewModel(IEventAggregator events)
        {
            _events = events;
        }

        /*
         * Activities of this screen 
         */
         public void LawfulGood()
         {
            AlignmentInfo = StaticMembers.LawfulGood;
         }

        public void LawfulNeutral()
        {
            AlignmentInfo = StaticMembers.LawfulNeutral;
        }
        public void LawfulEvil()
        {
            AlignmentInfo = StaticMembers.LawfulEvil;
        }

        public void NeutralGood()
        {
            AlignmentInfo = StaticMembers.NeutralGood;
        }

        public void TrueNeutral()
        {
            AlignmentInfo = StaticMembers.TrueNeutral;
        }

        public void NeutralEvil()
        {
            AlignmentInfo = StaticMembers.NeutralEvil;
        }

        public void ChaoticGood()
        {
            AlignmentInfo = StaticMembers.ChaoticGood;
        }

        public void ChaoticNeutral()
        {
            AlignmentInfo = StaticMembers.ChaoticNeutral;
        }

        public void ChaoticEvil()
        {
            AlignmentInfo = StaticMembers.ChaoticEvil;
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
