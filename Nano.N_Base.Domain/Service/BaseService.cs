using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using System;
using System.Linq;
using static Nano.N_Base.Domain.Commom.ExecaoComum;

namespace Nano.N_Base.Domain.Service
{
    internal class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository) => _repository = repository;

        public virtual bool Save(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException($"Para salvar {entity.GetType().Name} não pode ser nulo.");

            return _repository.Save(entity);
        }

        public IQueryable<TEntity> GetAll() => _repository.GetAll();

        public TEntity GetById(long id)
        {
            if (id <= 0)
                ErroDeIdInvalido(typeof(TEntity));

            return _repository.GetById(id);
        }

        public bool Delete(long id)
        {
            if (id <= 0)
                ErroDeIdInvalido(typeof(TEntity));
            return _repository.Delete(id);
        }
    }
}
