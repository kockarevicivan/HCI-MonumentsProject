using HCI.MonumentsProject.DAL.Contracts;
using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HCI.MonumentsProject.DAL.Repositories
{
    public class TagRepository : BaseRepository, ITagRepository
    {
        public void Create(Tag tag)
        {
            context.Tags.Add(tag);

            context.Notify();
        }

        public IEnumerable<Tag> GetAll()
        {
            return context.Tags;
        }

        public Tag GetById(string id)
        {
            return context.Tags.Where(t => t.Id == id).FirstOrDefault();
        }

        public void Update(Tag tag)
        {
            Tag found = context.Tags.Where(t => t.Id == tag.Id).FirstOrDefault();

            if (found != null)
            {
                context.Tags.Remove(found);
            }

            context.Tags.Add(tag);

            context.Notify();
        }

        public void Delete(string id)
        {
            Tag found = context.Tags.Where(t => t.Id == id).FirstOrDefault();

            if (found != null)
            {
                context.Tags.Remove(found);
            }

            context.Notify();
        }
    }
}
