using System.Collections.Generic;
using static DNDApi.Models.Character;

namespace DNDApi.Models
{
    public class Save
    {
        public long actionID { get; set; }
        public AbilityType ability { get; set; }
        public int value { get; set; }
        public string success_type { get; set; }
        public AbilityType damage_type { get; set; }
        public string damage_dice { get; set; }
        public int? damage_bonus { get; set; }
    }
}