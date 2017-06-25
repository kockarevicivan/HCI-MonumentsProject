using HCI.MonumentsProject.Domain.Entities;

namespace HCI.MonumentsProject.DAL.Repositories
{
    public class BaseRepository
    {
        protected UnitOfWork context;

        public BaseRepository()
        {
            context = UnitOfWork.GetInstance();
        }
    }
}
