using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDDesktopUI.Models
{
    class CharacterRace
    {
        public String _CharacterRaceName { get; set; }
        public String _CharacterRaceDescription { get; set; }
        public String _CharacterRaceStats { get; set; }

        public CharacterRace(String CharacterRaceName, String CharacterRaceDescription, String CharacterRaceStats)
        {
            _CharacterRaceName = CharacterRaceName;
            _CharacterRaceDescription = CharacterRaceDescription;
            _CharacterRaceStats = CharacterRaceStats;
        }
    }
}
