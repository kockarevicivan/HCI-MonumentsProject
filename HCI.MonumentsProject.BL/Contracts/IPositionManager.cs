using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.BL.Contracts
{
    public interface IPositionManager
    {
        void Create(Position position);

        IEnumerable<Position> GetAll();
        Position GetByMonumentId(string monumentId);

        void Update(Position position);

        void Delete(string monumentId);
    }
}
