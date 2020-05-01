using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDDesktopUI.Models
{
    class CharacterClass
    {
        //Properties 
        public String _CharacterClassName { get; set; }
        public String _CharacterClassDescription { get; set; }
        public String _CharacterMainMechanic { get; set; }

        public CharacterClass(String CharacterClassName, String CharacterClassDescription, String CharacterMainMechanic)
        {
            _CharacterClassName = CharacterClassName;
            _CharacterClassDescription = CharacterClassDescription;
            _CharacterMainMechanic = CharacterMainMechanic;
        }
    }
}
