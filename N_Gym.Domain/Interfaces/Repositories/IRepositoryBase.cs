using System.Collections.Generic;
using System.Threading.Tasks;

namespace N_Gym.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        bool Insert(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(int id);        
    }
}