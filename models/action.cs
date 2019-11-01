using System.Collections.Generic;

namespace DNDApi.Models
{
    public class Action
    {
        public long characterID { get; set; }
        public long actionID { get; set; }
        public string desc { get; set; }
        public string name { get; set; }
        public Attack attack { get; set; }
        public Save save { get; set; }
    }
}