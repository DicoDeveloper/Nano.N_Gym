using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Validation.Interface;
using System.Linq;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class GymBaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;
        private readonly IBaseValidation<TEntity> _validation;

        public GymBaseService(IBaseRepository<TEntity> repository, IBaseValidation<TEntity> validation)
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

        public bool Delete(TEntity entity)
        {
            _validation.ValidateEntityToDelete(entity);

            return _repository.Delete(entity);
        }

        public bool Delete(long id)
        {
            _validation.ValidateId(id);

            return _repository.Delete(id);
        }
    }
}
