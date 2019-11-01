namespace DNDApi.Models
{
    public class Speed
    {
        public long characterID { get; set; }
        public int walk { get; set; }
        public int climb { get; set; }
        public int burrow { get; set; }
        public int fly { get; set; }
        public int swim { get; set; }
    }
}