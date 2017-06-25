using System;
using System.Collections.Generic;

namespace HCI.MonumentsProject.Domain.Entities
{
    [Serializable]
    public class Monument
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MonumentTypeId { get; set; }
        public string MonumentEra { get; set; }///TODO put enumeration instead of int.
        public string IconPath { get; set; }
        public bool IsArchaeologicallyProcessed { get; set; }
        public bool IsOnUNESCOList { get; set; }
        public bool IsInPopulatedArea { get; set; }
        public string TouristStatus { get; set; }///TODO put enumeration instead of int.
        public float YearIncome { get; set; }
        public DateTime DateOfDiscovery { get; set; }

        #region [Custom Properties]
        public MonumentType MonumentType { get; set; }
        public List<Tag> Tags { get; set; }
        #endregion [Custom Properties]
    }
}
