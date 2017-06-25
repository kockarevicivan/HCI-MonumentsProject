using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.BL.Contracts
{
    public interface ITagManager
    {
        void Create(Tag tag);

        IEnumerable<Tag> GetAll();
        Tag GetById(string id);

        void Update(Tag tag);

        void Delete(string id);
    }
}
