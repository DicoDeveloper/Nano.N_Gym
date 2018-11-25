using System.Linq;

namespace Nano.N_Base.Domain.Interface.Service
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        bool Save(TEntity entity);
        IQueryable<TEntity> GetAll();
        TEntity GetById(long id);
        bool Delete(TEntity entity);
        bool Delete(long id);        
    }
}
