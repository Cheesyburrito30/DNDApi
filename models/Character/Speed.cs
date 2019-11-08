using Microsoft.EntityFrameworkCore;

namespace DNDApi.Models.Character
{
    [Owned]
    public class Speed
    {
        public int Walk { get; set; }
        public int Climb { get; set; }
        public int Burrow { get; set; }
        public int Fly { get; set; }
        public int Swim { get; set; }
    }
}