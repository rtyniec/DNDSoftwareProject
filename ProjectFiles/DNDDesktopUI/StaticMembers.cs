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
         
        //Barbarian 
        public static CharacterClass Barbarian = new CharacterClass("Barbarian",
                                                                    "A Brute, Raw-Powered Warrior who revels in the heat of battle.",
                                                                    "Rage - The Barbarian works themselves into a rage, giving them an array of bonuses in close combat.");

        //Bard 
        public static CharacterClass Bard = new CharacterClass("Bard",
                                                               "A Musical Caster who utilizes song and speech to cast various effects on opponents.",
                                                               "Baridic Inspiration - Fill an ally with heart, giving them a bonus on their next role.");

        //Cleric
        public static CharacterClass Cleric = new CharacterClass("Cleric",
                                                                 "A Devout Hybrid of Caster and Warrior that wields their faith as much as they wield their weapon.",
                                                                 "Divine Domain - Gain a variety of special powers from the god you worship.");

        //Druid 
        public static CharacterClass Druid = new CharacterClass("Druid",
                                                                "A Nature loving caster, who uses the wilds to stop all who would harm it.",
                                                                "Wild Shape - Change form into a beast for subterfuge, combat prowess, or mobility.");

        //Fighter  
        public static CharacterClass Fighter = new CharacterClass("Fighter",
                                                                  "A straight forward warrior who can be a one-person army of different fighting styles.",
                                                                  "Fighting Specialization and Extra Attacks- Gain proficiency in multiple fighting styles and attack multiple times.");

        //Monk  
        public static CharacterClass Monk = new CharacterClass("Monk",
                                                               "A Master of Martial Arts and Self-Control",
                                                               "Ki - Harness the power of living bodies to control yourself and others.");

        //Paladin  
        public static CharacterClass Paladin = new CharacterClass("Paladin",
                                                                  "A Warrior of Holy Justice, the Paladin uses to martial prowess to enforce order.",
                                                                  "Sacred Oath - Take an oath of duty which imbues you with holy powers.");

        //Ranger  
        public static CharacterClass Ranger = new CharacterClass("Ranger",
                                                                 "A Master of the Wilds, able to travel, hunt, and track with ease.",
                                                                 "Favored Enemy and Natural Explorer - Choose and enemy and environment type you specialize in.");

        //Rogue  
        public static CharacterClass Rogue = new CharacterClass("Rogue",
                                                                "A Master of stealth and sabatogue, the Rogue weaves their way through sitituations of combat and conversation with equal ease.",
                                                                "Sneak Attack - Explot and enemies weakness to your advantage, dealing extra damage.");

        //Sorcerer  
        public static CharacterClass Sorcerer = new CharacterClass("Sorcerer",
                                                                   "Magic corsing through their very veins, Sorcerers cast magic with ease and unintended side-effects.",
                                                                   "Wild Magic - You magic has trouble containing itself, causing all sorts of boons and banes as it flys.");

        //Warlock  
        public static CharacterClass Warlock = new CharacterClass("Warlock",
                                                                  "Feared and Enimatic, The Warlock gains power from sources of eldritch wonder and horror.",
                                                                  "Otherworldly Patron - Make a pact with an otherworldly being, giving you power at an ever negotiating cost.");

        //Wizard  
        public static CharacterClass Wizard = new CharacterClass("Wizard",
                                                                 "Forever conducting reasearc and studying magic, The Wizard casts wonderful spells learned from years of learning.",
                                                                 "Wizard School - Specialize in a type of magic, giving it a distinct advantage.");

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
