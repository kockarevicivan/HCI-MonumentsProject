using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.DAL.Contracts;
using HCI.MonumentsProject.DAL.Repositories;
using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.BL.Managers
{
    public class MonumentTypeManager : IMonumentTypeManager
    {
        private IMonumentTypeRepository _repository;

        public MonumentTypeManager()
        {
            _repository = new MonumentTypeRepository();
        }

        public void Create(MonumentType monumentType)
        {
            _repository.Create(monumentType);
        }

        public IEnumerable<MonumentType> GetAll()
        {
            return _repository.GetAll();
        }

        public MonumentType GetById(string id)
        {
            return _repository.GetById(id);
        }

        public void Update(MonumentType monumentType)
        {
            _repository.Update(monumentType);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
