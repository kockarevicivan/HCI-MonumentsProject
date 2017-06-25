using HCI.MonumentsProject.BL.Contracts;
using HCI.MonumentsProject.DAL.Contracts;
using HCI.MonumentsProject.DAL.Repositories;
using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;

namespace HCI.MonumentsProject.BL.Managers
{
    public class TagManager : ITagManager
    {
        private ITagRepository _repository;

        public TagManager()
        {
            _repository = new TagRepository();
        }

        public void Create(Tag tag)
        {
            _repository.Create(tag);
        }

        public IEnumerable<Tag> GetAll()
        {
            return _repository.GetAll();
        }

        public Tag GetById(string id)
        {
            return _repository.GetById(id);
        }

        public void Update(Tag tag)
        {
            _repository.Update(tag);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
