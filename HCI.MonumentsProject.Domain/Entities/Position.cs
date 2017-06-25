using System;

namespace HCI.MonumentsProject.Domain.Entities
{
    [Serializable]
    public class Position
    {
        public string MonumentId { get; set; }
        public float XPosition { get; set; }
        public float YPosition { get; set; }

        #region [Custom Properties]
        public Monument Monument { get; set; }
        #endregion [Custom Properties]
    }
}
