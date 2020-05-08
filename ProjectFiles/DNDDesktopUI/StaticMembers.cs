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
         * Races 
         */

        //Dwarf 
        public static CharacterRace Dwarf = new CharacterRace("Dwarf", "A Short, Hardy Mountain people steeped in tradition.", "+2 Constitution");

        //Elf 
        public static CharacterRace Elf = new CharacterRace("Elf", "A Slender, Elegent people who reguard their ancient citys and old ways as superior.", "+2 Dexterity");

        //Halfling  
        public static CharacterRace Halfling = new CharacterRace("Halfling", "A joyus small-folk, more focused on merryment than adventure.", "+2 Dexterity");

        //Human  
        public static CharacterRace Human = new CharacterRace("Human", "The jack of all trades, deterministic humans.", "+1 to All Ability Scores");

        //Dragonborn  
        public static CharacterRace Dragonborn = new CharacterRace("Dragonborn", 
            "A Race who's blood is mixed with dragons, giving them draconic apperence and powers.", "+2 Strength, +1 Charisma");

        //Gnome  
        public static CharacterRace Gnome = new CharacterRace("Gnome", "A Curious folk, looking for excitement where ever them can find it.", "+2 Intelligence");

        //Half-Elf 
        public static CharacterRace HalfElf = new CharacterRace("Half-Elf", 
            "A Mix of elf and human, accepted in both worlds but never welcome.", "+2 Charisma, +1 to all other Ability Scores");

        //Half-Orc 
        public static CharacterRace HalfOrc = new CharacterRace("Half-Orc", "A Mix of orc and human, carring the strength of their orc ancestry.", "+2 Strength, +1 Constitution");

        //Tiefling 
        public static CharacterRace Tiefling = new CharacterRace("Tiefling", 
            "A race who's blood has been touched by fiends, giving them a frightening apperence.", "+2 Charisma, +1 Intelligence");

        /*[-------------------------------------------------------------------------------------------------]*/

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

        /*[-------------------------------------------------------------------------------------------------]*/

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

        /*[-------------------------------------------------------------------------------------------------]*/

        /*
         * Descriptions 
         */

        //Alignments 
        public static string LawfulGood = "A lawful good character acts as a good person is expected or required to act.";
        public static string LawfulNeutral = "A lawful neutral character acts as law, tradition, or a personal code directs her.";
        public static string LawfulEvil = "A lawful evil villain methodically takes what they wants within the limits of their code of conduct without regard for whom it hurts.";
        public static string NeutralGood = "A neutral good character does the best that a good person can do.";
        public static string TrueNeutral = "A neutral character does what seems to be a good idea.";
        public static string NeutralEvil = "A neutral evil villain does whatever they can get away with.";
        public static string ChaoticGood = "A chaotic good character acts as their conscience directs them with little regard for what others expect of them.";
        public static string ChaoticNeutral = "A chaotic neutral character follows there whims.";
        public static string ChaoticEvil = "A chaotic evil character does whatever their greed, hatred, and lust for destruction drive them to do";

        //Backgrounds 
        public static string Acoylte = "One deveoted to the faith of a certain god or diety.";
        public static string Charlatan = "You know how to work with and manipulate people.";
        public static string Criminal = "You've been on the wrong side of the law.";
        public static string Entertainer = "You know how to perform and put on specticles.";
        public static string FolkHero = "You have gained renown amoung the common people.";
        public static string GuildArtisan = "You have made a living from a particular trade skill.";
        public static string Hermit = "You were secluded for a large portion of your life.";
        public static string Noble = "You come from a powerful or well connected family";
        public static string Outlander = "You had never taken a liking to society.";
        public static string Sage = "You have studied hard in your years.";
        public static string Sailor = "You've spent years abord vessel sailing the seas.";
        public static string Soldier = "You made your way as a member of a military or guard.";
        public static string Urchin = "You grew up on the streets.";

    }
}
