using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.DAL.Contracts;
using HCI.MonumentsProject.DAL.Repositories;
using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.BL.Managers
{
    public class PositionManager : IPositionManager
    {
        private IPositionRepository _repository;

        public PositionManager()
        {
            _repository = new PositionRepository();
        }

        public void Create(Position position)
        {
            _repository.Create(position);
        }

        public IEnumerable<Position> GetAll()
        {
            return _repository.GetAll();
        }

        public Position GetByMonumentId(string monumentId)
        {
            return _repository.GetByMonumentId(monumentId);
        }

        public void Update(Position position)
        {
            _repository.Update(position);
        }

        public void Delete(string monumentId)
        {
            _repository.Delete(monumentId);
        }
    }
}
