using Caliburn.Micro;
using DNDDesktopUI;
using DNDDesktopUI.Models;
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
         /*
         * Properties 
         */
        public string ClassName { get; set; } = "Choose Your Class";
        public string ClassDescription { get; set; }
        public string MainMechanic { get; set; }
        public CharacterClass ChosenClass { get; set; }
        
        /*
         * Member 
         */
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
            ClassName = StaticMembers.Barbarian._CharacterClassName;
            ClassDescription = StaticMembers.Barbarian._CharacterClassDescription;
            MainMechanic = StaticMembers.Barbarian._CharacterMainMechanic;
            ChosenClass = StaticMembers.Barbarian;
        }

        public void BardButton()
        {
            ClassName = StaticMembers.Bard._CharacterClassName;
            ClassDescription = StaticMembers.Bard._CharacterClassDescription;
            MainMechanic = StaticMembers.Bard._CharacterMainMechanic;
            ChosenClass = StaticMembers.Bard;
        }

        public void ClericButton()
        {
            ClassName = StaticMembers.Cleric._CharacterClassName;
            ClassDescription = StaticMembers.Cleric._CharacterClassDescription;
            MainMechanic = StaticMembers.Cleric._CharacterMainMechanic;
            ChosenClass = StaticMembers.Cleric;
        }

        public void DruidButton()
        {
            ClassName = StaticMembers.Druid._CharacterClassName;
            ClassDescription = StaticMembers.Druid._CharacterClassDescription;
            MainMechanic = StaticMembers.Druid._CharacterMainMechanic;
            ChosenClass = StaticMembers.Druid;
        }

        public void FighterButton()
        {
            ClassName = StaticMembers.Fighter._CharacterClassName;
            ClassDescription = StaticMembers.Fighter._CharacterClassDescription;
            MainMechanic = StaticMembers.Fighter._CharacterMainMechanic;
            ChosenClass = StaticMembers.Fighter;
        }

        public void MonkButton()
        {
            ClassName = StaticMembers.Monk._CharacterClassName;
            ClassDescription = StaticMembers.Monk._CharacterClassDescription;
            MainMechanic = StaticMembers.Monk._CharacterMainMechanic;
            ChosenClass = StaticMembers.Monk;
        }

        public void PaladinButton()
        {
            ClassName = StaticMembers.Paladin._CharacterClassName;
            ClassDescription = StaticMembers.Paladin._CharacterClassDescription;
            MainMechanic = StaticMembers.Paladin._CharacterMainMechanic;
            ChosenClass = StaticMembers.Paladin;
        }

        public void RangerButton()
        {
            ClassName = StaticMembers.Ranger._CharacterClassName;
            ClassDescription = StaticMembers.Ranger._CharacterClassDescription;
            MainMechanic = StaticMembers.Ranger._CharacterMainMechanic;
            ChosenClass = StaticMembers.Ranger;
        }

        public void RogueButton()
        {
            ClassName = StaticMembers.Rogue._CharacterClassName;
            ClassDescription = StaticMembers.Rogue._CharacterClassDescription;
            MainMechanic = StaticMembers.Rogue._CharacterMainMechanic;
            ChosenClass = StaticMembers.Rogue;
        }

        public void SorcererButton()
        {
            ClassName = StaticMembers.Sorcerer._CharacterClassName;
            ClassDescription = StaticMembers.Sorcerer._CharacterClassDescription;
            MainMechanic = StaticMembers.Sorcerer._CharacterMainMechanic;
            ChosenClass = StaticMembers.Sorcerer;
        }

        public void WarlockButton()
        {
            ClassName = StaticMembers.Warlock._CharacterClassName;
            ClassDescription = StaticMembers.Warlock._CharacterClassDescription;
            MainMechanic = StaticMembers.Warlock._CharacterMainMechanic;
            ChosenClass = StaticMembers.Warlock;
        }

        public void WizardButton()
        {
            ClassName = StaticMembers.Wizard._CharacterClassName;
            ClassDescription = StaticMembers.Wizard._CharacterClassDescription;
            MainMechanic = StaticMembers.Wizard._CharacterMainMechanic;
            ChosenClass = StaticMembers.Wizard;
        }

        /*
         * Navigation 
         */
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
