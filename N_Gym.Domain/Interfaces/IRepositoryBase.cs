using System.Collections.Generic;

namespace N_Gym.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        bool Insert(TEntity entity);
    }
}