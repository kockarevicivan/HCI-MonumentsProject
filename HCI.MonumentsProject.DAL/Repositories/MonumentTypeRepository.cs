using HCI.MonumentsProject.DAL.Contracts;
using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HCI.MonumentsProject.DAL.Repositories
{
    public class MonumentTypeRepository : BaseRepository, IMonumentTypeRepository
    {
        public void Create(MonumentType monumentType)
        {
            context.MonumentTypes.Add(monumentType);

            context.Notify();
        }
        
        public IEnumerable<MonumentType> GetAll()
        {
            return context.MonumentTypes;
        }

        public MonumentType GetById(string id)
        {
            return context.MonumentTypes.Where(m => m.Id == id).FirstOrDefault();
        }

        public void Update(MonumentType monumentType)
        {
            MonumentType found = context.MonumentTypes.Where(mt => mt.Id == monumentType.Id).FirstOrDefault();

            if (found != null)
            {
                context.MonumentTypes.Remove(found);
            }

            context.MonumentTypes.Add(monumentType);

            context.Notify();
        }

        public void Delete(string id)
        {
            MonumentType found = context.MonumentTypes.Where(mt => mt.Id == id).FirstOrDefault();

            if (found != null)
            {
                context.MonumentTypes.Remove(found);
            }

            context.Notify();
        }
    }
}
