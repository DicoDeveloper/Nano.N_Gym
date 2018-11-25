using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using System;
using System.Linq;
using static Nano.N_Base.Validation.ValidationFactoryBase;

namespace Nano.N_Base.Domain.Service
{
    internal class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository) => _repository = repository;

        public virtual bool Save(TEntity entity)
        {
            ValidateBase(entity);

            return _repository.Save(entity);
        }

        public IQueryable<TEntity> GetAll() => _repository.GetAll();

        public TEntity GetById(long id)
        {
            ValidateIdBase(id);

            return _repository.GetById(id);
        }

        public bool Delete(TEntity entity)
        {
            ValidateDeleteBase(entity);

            return _repository.Delete(entity);
        }

        public bool Delete(long id)
        {
            ValidateIdBase(id);

            return _repository.Delete(id);
        }
    }
}
