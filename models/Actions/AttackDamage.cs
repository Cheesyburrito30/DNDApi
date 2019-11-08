using Microsoft.EntityFrameworkCore;

namespace DNDApi.Models.Actions
{
    [Owned]
    public class AttackDamage
    {
        public int Id { get; set; }
        public string DamageType { get; set; }
        public string DamageDice { get; set; }
        public int DamageBonus { get; set; }
    }
}
