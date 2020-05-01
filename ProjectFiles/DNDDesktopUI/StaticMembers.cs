using DNDDesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDDesktopUI
{
    static class StaticMembers
    {
        /*
         * Classes 
         */
        public static CharacterClass Barbarian = new CharacterClass("Barbarian",
                                                             "A Brute, Raw-Powered Warrior who revels in the heat of battle.",
                                                             "Rage - The Barbarian works themselves into a rage, giving them an array of bonuses in close combat.");
        
        /*
         * View Screen Numbers 
         */
        
        //Title Screen 
        public const int TITLE_SCREEN = 1;

        //Character List 
        public const int CHAR_LIST = 2;

        //Race Choice 
        public const int RACE_CHOICE = 3;
        
        //Class Choice 
        public const int CLASS_CHOICE = 4;
        
        //Ability Scores 
        public const int ABILITY_SCORES = 5;
        
        //Skills 
        public const int SKILLS = 6;
        
        //Bonds, Flaws, Ideals 
        public const int BONDS_FLAWS_IDEALS = 7;

        //Character Overview 
        public const int OVERVIEW = 8;
    }
}
