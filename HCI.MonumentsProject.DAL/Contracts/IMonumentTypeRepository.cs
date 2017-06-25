using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.DAL.Contracts
{
    public interface IMonumentTypeRepository
    {
        void Create(MonumentType monumentType);

        IEnumerable<MonumentType> GetAll();
        MonumentType GetById(string id);

        void Update(MonumentType monumentType);

        void Delete(string id);
    }
}
