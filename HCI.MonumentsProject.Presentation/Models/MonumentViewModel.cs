using System;

namespace HCI.MonumentsProject.Presentation.Models
{
    public class MonumentViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MonumentTypeId { get; set; }
        public int MonumentEra { get; set; }///TODO put enumeration instead of int.
        public string IconPath { get; set; }
        public bool IsArchaeologicallyProcessed { get; set; }
        public bool IsOnUNESCOList { get; set; }
        public bool IsInPopulatedArea { get; set; }
        public int TouristStatus { get; set; }///TODO put enumeration instead of int.
        public float YearIncome { get; set; }
        public DateTime DateOfDiscovery { get; set; }
    }
}
