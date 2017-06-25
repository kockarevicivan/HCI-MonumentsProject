using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.BL.Contracts
{
    public interface IMonumentManager
    {
        void Create(Monument monument);

        IEnumerable<Monument> GetAll();
        IEnumerable<Monument> GetByName(string name);
        IEnumerable<Monument> GetByType(string typeId);///TODO not int, make enum
        IEnumerable<Monument> GetByEra(string era);///TODO not int, make enum
        IEnumerable<Monument> GetByTouristStatus(string status);///TODO not int, make enum
        Monument GetById(string id);

        void Update(Monument monument);

        void Delete(string id);
    }
}
