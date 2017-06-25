using HCI.MonumentsProject.DAL.Contracts;
using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HCI.MonumentsProject.DAL.Repositories
{
    public class MonumentRepository : BaseRepository, IMonumentRepository
    {
        public void Create(Monument monument)
        {
            context.Monuments.Add(monument);

            context.Notify();
        }
        
        public IEnumerable<Monument> GetAll()
        {
            return context.Monuments;
        }

        public IEnumerable<Monument> GetByType(string typeId)
        {
            return context.Monuments.Where(m => m.MonumentTypeId == typeId);
        }

        public IEnumerable<Monument> GetByName(string name)
        {
            return context.Monuments.Where(m => m.Name == name);
        }

        public IEnumerable<Monument> GetByTouristStatus(string status)
        {
            return context.Monuments.Where(m => m.TouristStatus == status);
        }

        public IEnumerable<Monument> GetByEra(string era)
        {
            return context.Monuments.Where(m => m.MonumentEra == era);
        }

        public Monument GetById(string id)
        {
            return context.Monuments.Where(m => m.Id == id).FirstOrDefault();
        }

        public void Update(Monument monument)
        {
            Monument found = context.Monuments.Where(m => m.Id == monument.Id).FirstOrDefault();

            if (found != null)
            {
                context.Monuments.Remove(found);
            }

            context.Monuments.Add(monument);

            context.Notify();
        }

        public void Delete(string id)
        {
            Monument found = context.Monuments.Where(m => m.Id == id).FirstOrDefault();

            if (found != null)
            {
                context.Monuments.Remove(found);
            }

            context.Notify();
        }
    }
}
