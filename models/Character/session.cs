using System;

namespace DNDApi.Models.Character
{
    public class Session
    {
        public long ID { get; set; }
        public string summary { get; set; }
        public string date { get; set; }
        public string monsters { get; set; }
        public int exp { get; set; }
        public string items { get; set; }

        public void updateSummary(string newSummary)
        {
            this.summary = newSummary;
        }
    }
}