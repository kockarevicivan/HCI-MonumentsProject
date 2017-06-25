using HCI.MonumentsProject.DAL.Contracts;
using HCI.MonumentsProject.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace HCI.MonumentsProject.DAL.Repositories
{
    public class PositionRepository : BaseRepository, IPositionRepository
    {
        public void Create(Position position)
        {
            ///TODO control if exists
            context.Positions.Add(position);

            context.Notify();
        }

        public IEnumerable<Position> GetAll()
        {
            return context.Positions;
        }

        public Position GetByMonumentId(string monumentId)
        {
            return context.Positions.Where(p => p.MonumentId == monumentId).FirstOrDefault();
        }

        public void Update(Position position)
        {
            Position found = context.Positions.Where(p => p.MonumentId == position.MonumentId).FirstOrDefault();

            if (found != null)
            {
                context.Positions.Remove(found);
            }

            context.Positions.Add(position);

            context.Notify();
        }

        public void Delete(string monumentId)
        {
            Position found = context.Positions.Where(p => p.MonumentId == monumentId).FirstOrDefault();

            if (found != null)
            {
                context.Positions.Remove(found);
            }

            context.Notify();
        }
    }
}
