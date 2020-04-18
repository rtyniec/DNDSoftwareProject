using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDTransfer.Library.Models
{
    public class CharacterModel
    {
        public string CharacterName { get; set; }//primary key
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Class { get; set; }
        public string Background { get; set; }
        public string Race { get; set; }
        public string Alignment { get; set; }
        public string ExperiencePoints { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
