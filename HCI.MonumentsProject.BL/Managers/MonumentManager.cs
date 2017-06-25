using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.DAL.Contracts;
using HCI.MonumentsProject.DAL.Repositories;
using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.BL.Managers
{
    public class MonumentManager : IMonumentManager
    {
        private IMonumentRepository _repository;

        public MonumentManager()
        {
            _repository = new MonumentRepository();
        }

        public void Create(Monument monument)
        {
            _repository.Create(monument);
        }

        public IEnumerable<Monument> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<Monument> GetByEra(string era)
        {
            return _repository.GetByEra(era);
        }

        public IEnumerable<Monument> GetByName(string name)
        {
            return _repository.GetByName(name);
        }

        public IEnumerable<Monument> GetByTouristStatus(string status)
        {
            return _repository.GetByTouristStatus(status);
        }

        public IEnumerable<Monument> GetByType(string typeId)
        {
            return _repository.GetByType(typeId);
        }

        public Monument GetById(string id)
        {
            return _repository.GetById(id);
        }

        public void Update(Monument monument)
        {
            _repository.Update(monument);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
