using System.Linq;

namespace Nano.N_Base.Domain.Interface.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        bool Save(TEntity entity);
        IQueryable<TEntity> GetAll();
        TEntity GetById(long id);
        bool Delete(long id);
        bool Delete(TEntity entity);
    }
}
