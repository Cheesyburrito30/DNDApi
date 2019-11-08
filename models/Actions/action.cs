using Microsoft.EntityFrameworkCore;

namespace DNDApi.Models.Actions
{
    [Owned]
    public class Action
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }
        public string Name { get; set; }
        public Attack Attack { get; set; } = new Attack();
        //public Save Save { get; set; } = new Save();

        public enum DamageType
        {
            Acid,
            Bludgeoning,
            Cold,
            Fire,
            Force,
            Lightning,
            Necrotic,
            Piercing,
            Poison,
            Psychic,
            Radiant,
            Slashing,
            Thunder
        }
    }
}