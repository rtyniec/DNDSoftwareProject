using Caliburn.Micro;
using DNDDesktopUI;
using DNDDesktopUI.Models;
using Dungeons_DragonsCharacterBuilder.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_DragonsCharacterBuilder.ViewModels
{
    class RaceChoiceViewModel : Screen
    {
        public String RaceName { get; set; } = "Choose a Race";
        public String RaceDescription { get; set; }
        public String RaceStats { get; set; }
        public CharacterRace ChosenRace { get; set; }
        
        private IEventAggregator _events;
        
        public RaceChoiceViewModel(IEventAggregator events)
        {
            _events = events;
        }

        /*
         * Activities of this view 
         */
         public void DwarfButton()
         {
            RaceName = StaticMembers.Dwarf._CharacterRaceName;
            RaceDescription = StaticMembers.Dwarf._CharacterRaceDescription;
            RaceStats = StaticMembers.Dwarf._CharacterRaceStats;
            ChosenRace = StaticMembers.Dwarf;
         }

        public void ElfButton()
        {
            RaceName = StaticMembers.Elf._CharacterRaceName;
            RaceDescription = StaticMembers.Elf._CharacterRaceDescription;
            RaceStats = StaticMembers.Elf._CharacterRaceStats;
            ChosenRace = StaticMembers.Elf;
        }

        public void HalflingButton()
        {
            RaceName = StaticMembers.Halfling._CharacterRaceName;
            RaceDescription = StaticMembers.Halfling._CharacterRaceDescription;
            RaceStats = StaticMembers.Halfling._CharacterRaceStats;
            ChosenRace = StaticMembers.Halfling;
        }

        public void HumanButton()
        {
            RaceName = StaticMembers.Human._CharacterRaceName;
            RaceDescription = StaticMembers.Human._CharacterRaceDescription;
            RaceStats = StaticMembers.Human._CharacterRaceStats;
            ChosenRace = StaticMembers.Human;
        }

        public void DragonbornButton()
        {
            RaceName = StaticMembers.Dragonborn._CharacterRaceName;
            RaceDescription = StaticMembers.Dragonborn._CharacterRaceDescription;
            RaceStats = StaticMembers.Dragonborn._CharacterRaceStats;
            ChosenRace = StaticMembers.Dragonborn;
        }

        public void GnomeButton()
        {
            RaceName = StaticMembers.Gnome._CharacterRaceName;
            RaceDescription = StaticMembers.Gnome._CharacterRaceDescription;
            RaceStats = StaticMembers.Gnome._CharacterRaceStats;
            ChosenRace = StaticMembers.Gnome;
        }

        public void HalfElfButton()
        {
            RaceName = StaticMembers.HalfElf._CharacterRaceName;
            RaceDescription = StaticMembers.HalfElf._CharacterRaceDescription;
            RaceStats = StaticMembers.HalfElf._CharacterRaceStats;
            ChosenRace = StaticMembers.HalfElf;
        }
        public void HalfOrcButton()
        {
            RaceName = StaticMembers.HalfOrc._CharacterRaceName;
            RaceDescription = StaticMembers.HalfOrc._CharacterRaceDescription;
            RaceStats = StaticMembers.HalfOrc._CharacterRaceStats;
            ChosenRace = StaticMembers.HalfOrc;
        }

        public void TieflingButton()
        {
            RaceName = StaticMembers.Tiefling._CharacterRaceName;
            RaceDescription = StaticMembers.Tiefling._CharacterRaceDescription;
            RaceStats = StaticMembers.Tiefling._CharacterRaceStats;
            ChosenRace = StaticMembers.Tiefling;
        }

        public void MoveToClassChoice()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(StaticMembers.CLASS_CHOICE));
        }

        public void MoveToTitleScreen()
        {
            _events.PublishOnUIThread(new MoveViewsEventModel(StaticMembers.TITLE_SCREEN));
        }
    }
}
