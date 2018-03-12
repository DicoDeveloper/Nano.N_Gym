using System.Collections.Generic;
using System.Threading.Tasks;

namespace N_Base.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        bool Insert(TEntity entity);
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> Get(long id);    
    }
}