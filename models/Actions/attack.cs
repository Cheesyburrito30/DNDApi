using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DNDApi.Models.Actions
{
    public class Attack
    {
        public int Bonus { get; set; }
        public ICollection<AttackDamage> Damage { get; set; } = new List<AttackDamage>();
    }
}