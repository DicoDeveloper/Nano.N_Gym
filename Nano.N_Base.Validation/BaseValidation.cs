using Nano.N_Base.Model.Exception;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Validation
{
    public class BaseValidation<TEntity> : IBaseValidation<TEntity> where TEntity : class
    {
        public virtual void Validate(TEntity entity)
        {
            if (entity == null) throw new NullEntityException($"Exceção de entidade nula");
        }

        public void ValidateId(long id)
        {
            if (id <= 0) throw new InvalidIdentifierException("Identificador com valor inválido");
        }

        public long ValidateToDelete(TEntity entity)
        {
            Validate(entity);

            long id = (long)entity.GetType().GetProperty("Id").GetValue(entity);
            ValidateId(id);

            return id;
        }
    }
}
