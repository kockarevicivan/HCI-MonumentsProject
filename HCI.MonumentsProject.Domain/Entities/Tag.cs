using System;

namespace HCI.MonumentsProject.Domain.Entities
{
    [Serializable]
    public class Tag
    {
        public string Id { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
    }
}
