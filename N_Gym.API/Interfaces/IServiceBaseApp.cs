using System.Collections.Generic;
using System.Threading.Tasks;

namespace N_Gym.API.Interfaces
{
    public interface IServiceBaseApp<TEntity> where TEntity : class
    {
        bool Insert(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(long id); 
    }
}