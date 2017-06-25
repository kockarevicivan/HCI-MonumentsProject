using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.DAL.Contracts
{
    public interface ITagRepository
    {
        void Create(Tag tag);

        IEnumerable<Tag> GetAll();
        Tag GetById(string id);

        void Update(Tag tag);

        void Delete(string id);
    }
}
