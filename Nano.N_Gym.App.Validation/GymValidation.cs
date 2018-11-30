using Nano.N_Base.Model.Exception;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Gym.App.Validation
{
    internal class GymValidation<TEntity> : IBaseValidation<TEntity> where TEntity : class
    {
        public virtual void Validate(TEntity entity)
        {
            if (entity == null) throw new NullEntityException($"Exceção de entidade nula");
        }

        public void ValidateId(long id)
        {
            if (id <= 0) throw new InvalidIdentifierException("Identificador com valor inválido");
        }

        public void ValidateEntityToDelete(TEntity entity)
        {
            if (entity == null) throw new NullEntityException($"Exceção de entidade nula");

            long? id = (long?)entity.GetType().GetProperty("Id")?.GetValue(entity);

            if (!id.HasValue) throw new InvalidIdentifierException("Identificador com valor inválido");
        }
    }
}