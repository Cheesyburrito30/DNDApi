using System;
using System.Collections.Generic;
using DNDApi.Models.Actions;

namespace DNDApi.Models.Character
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
        public Speed Speed { get; set; } = new Speed();
        public bool Hover { get; set; }
        public Ability Abilities { get; set; } = new Ability();
        public Ability Saves { get; set; } = new Ability();
        public Skill Skills { get; set; } = new Skill();
        public string Senses { get; set; }
        public string Languages { get; set; }
        public ICollection<Actions.Action> Actions { get; set; }

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