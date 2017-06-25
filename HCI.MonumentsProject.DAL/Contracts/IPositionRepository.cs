using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.DAL.Contracts
{
    public interface IPositionRepository
    {
        void Create(Position position);

        IEnumerable<Position> GetAll();
        Position GetByMonumentId(string monumentId);

        void Update(Position position);

        void Delete(string monumentId);
    }
}
