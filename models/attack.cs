using System.Collections.Generic;

namespace DNDApi.Models
{
    public class Attack
    {
        public long actionID { get; set; }
        public long attackID { get; set; }
        public int bonus { get; set; }
        public ICollection<AttackDamage> damage { get; set; }
    }
}