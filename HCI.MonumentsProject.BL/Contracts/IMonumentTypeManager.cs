using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.BL.Contracts
{
    public interface IMonumentTypeManager
    {
        void Create(MonumentType monumentType);

        IEnumerable<MonumentType> GetAll();
        MonumentType GetById(string id);

        void Update(MonumentType monumentType);

        void Delete(string id);
    }
}
