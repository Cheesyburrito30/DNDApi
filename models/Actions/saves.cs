namespace DNDApi.Models.Actions
{
    public class Save
    {
        public int Id { get; set; }
        public string Ability { get; set; }
        public int Value { get; set; }
        public string SuccessType { get; set; }
        public string DamageType { get; set; }
        public string DamageDice { get; set; }
        public int? DamageBonus { get; set; }
    }
}