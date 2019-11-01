using System;
using System.Collections.Generic;

namespace DNDApi.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Alignment { get; set; }
        public int ArmorClass { get; set; }
        public int HitPoints { get; set; }
        public string HitDice { get; set; }
        public Speed Speed { get; set; }
        public bool Hover { get; set; }
        public Ability Abilities { get; set; }
        public Ability Saves { get; set; }
        public Skill Skills { get; set; }
        public string Senses { get; set; }
        public string Languages { get; set; }
        public ICollection<Action> Actions { get; set; }
        public ICollection<Action> Reactions { get; set; }
        
        public enum AbilityType 
        {
            Strength,
            Dexterity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma
        }
        public enum SpeedType
        {
            Walk,
            Climb,
            Burrow,
            Fly,
            Swim,
        }
        public enum SkillType
        {
            Acrobatics,
            AnimalHandling,
            Arcana,
            Athletics,
            Deception,
            History,
            Insight,
            Intimidation,
            Investigation,
            Medicine,
            Nature,
            Perception,
            Performance,
            Persuasion,
            Religion,
            SleightOfHand,
            Stealth,
            Survival,
        }
    }
}