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
        public string AlignmentInfo { get; set; } = "Pick a Alignment";
        public string BackgroundInfo { get; set; } = "Pick a Background";
        public string ChosenAlignment { get; set; }
        public string ChosenBackground { get; set; }

        private IEventAggregator _events;

        public BondsFlawsIdealsViewModel(IEventAggregator events)
        {
            _events = events;
        }

        /*
         * Activities of this screen 
         */

         //Alignments 
         public void LawfulGood()
         {
            AlignmentInfo = ChosenAlignment = StaticMembers.LawfulGood;
        }

        public void LawfulNeutral()
        {
            AlignmentInfo = ChosenAlignment = StaticMembers.LawfulNeutral;
        }
        public void LawfulEvil()
        {
            AlignmentInfo = ChosenAlignment = StaticMembers.LawfulEvil;
        }

        public void NeutralGood()
        {
            AlignmentInfo = ChosenAlignment = StaticMembers.NeutralGood;
        }

        public void TrueNeutral()
        {
            AlignmentInfo = ChosenAlignment = StaticMembers.TrueNeutral;
        }

        public void NeutralEvil()
        {
            AlignmentInfo = ChosenAlignment = StaticMembers.NeutralEvil;
        }

        public void ChaoticGood()
        {
            AlignmentInfo = ChosenAlignment = StaticMembers.ChaoticGood;
        }

        public void ChaoticNeutral()
        {
            AlignmentInfo = ChosenAlignment = StaticMembers.ChaoticNeutral;
        }

        public void ChaoticEvil()
        {
            AlignmentInfo = ChosenAlignment = StaticMembers.ChaoticEvil;
        }

        //Background 
        public void Acolyte()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Acoylte;
        }

        public void Charlatan()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Charlatan;
        }

        public void Criminal()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Criminal;
        }

        public void Entertainer()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Entertainer;
        }

        public void FolkHero()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.FolkHero;
        }

        public void GuildArtisan()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.GuildArtisan;
        }

        public void Hermit()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Hermit;
        }

        public void Noble()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Noble;
        }

        public void Outlander()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Outlander;
        }

        public void Sage()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Sage;
        }

        public void Sailor()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Sailor;
        }

        public void Soldier()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Soldier;
        }

        public void Urchin()
        {
            BackgroundInfo = ChosenBackground = StaticMembers.Urchin;
        }

        /*
         * Navigation 
         */

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
