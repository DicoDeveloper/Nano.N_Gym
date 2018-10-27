using Nano.N_Base.Data.Interface;
using Nano.N_Base.Domain.Interface.Repository;
using System.Linq;

namespace Nano.N_Base.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly IBaseContext<TEntity> _context;

        public BaseRepository(IBaseContext<TEntity> context) => _context = context;

        public bool Save(TEntity entity) => _context.Save(entity);

        public IQueryable<TEntity> GetAll() => _context.GetAll();

        public TEntity GetById(long id) => _context.GetById(id);

        public bool Delete(long id) => _context.Delete(id);
    }
}
