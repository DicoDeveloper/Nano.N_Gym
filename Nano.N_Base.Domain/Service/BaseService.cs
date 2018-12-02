using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Validation.Interface;
using System.Linq;

namespace Nano.N_Base.Domain.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;
        private readonly IBaseValidation<TEntity> _validation;

        public BaseService(IBaseRepository<TEntity> repository, IBaseValidation<TEntity> validation)
        {
            _repository = repository;
            _validation = validation;
        }

        public virtual bool Save(TEntity entity)
        {
            _validation.Validate(entity);

            return _repository.Save(entity);
        }

        public IQueryable<TEntity> GetAll() => _repository.GetAll();

        public TEntity GetById(long id)
        {
            _validation.ValidateId(id);

            return _repository.GetById(id);
        }

        public virtual bool Delete(TEntity entity)
        {
            long id = _validation.ValidateToDelete(entity);

            return _repository.Delete(id);
        }

        public bool Inactivate(long id)
        {
            _validation.ValidateId(id);

            return _repository.Inactivate(id);
        }
    }
}
