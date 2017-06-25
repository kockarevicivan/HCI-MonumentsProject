using System;

namespace HCI.MonumentsProject.Domain.Entities
{
    [Serializable]
    public class MonumentType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }
    }
}
