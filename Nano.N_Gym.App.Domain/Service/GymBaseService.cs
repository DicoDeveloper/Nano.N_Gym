using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using System.Linq;
using static Nano.N_Gym.App.Validation.ValidationFactoryGym;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class GymBaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public GymBaseService(IBaseRepository<TEntity> repository) => _repository = repository;

        public virtual bool Save(TEntity entity)
        {
            Validate(entity);

            return _repository.Save(entity);
        }

        public IQueryable<TEntity> GetAll() => _repository.GetAll();

        public TEntity GetById(long id)
        {
            ValidateId(id);

            return _repository.GetById(id);
        }

        public bool Delete(TEntity entity)
        {
            ValidateDelete(entity);

            return _repository.Delete(entity);
        }

        public bool Delete(long id)
        {
            ValidateId(id);

            return _repository.Delete(id);
        }
    }
}
