using System;

namespace HCI.MonumentsProject.Domain.Entities
{
    [Serializable]
    public class MonumentTag
    {
        public string MonumentId { get; set; }
        public string TagId { get; set; }
    }
}
