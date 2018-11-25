using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Model.Exception;
using Nano.N_Base.Validation.Sistema;

namespace Nano.N_Base.Validation
{
    public static class ValidationFactoryBase
    {
        public static void ValidateBase<TEntity>(TEntity entity)
        {
            switch (entity)
            {
                case AgendamentoBase agendamento:
                    AgendamentoBaseValidation.Validate(agendamento);
                    break;
                default:
                    throw entity == null ? new NullEntityException($"Exceção de entidade nula") :
                    throw new InvalidEntityException("Exceção de entidade inválida");
            }
        }

        public static void ValidateIdBase(long id)
        {
            if (id <= 0) throw new InvalidIdentifierException("Identificador com valor inválido");
        }

        public static void ValidateDeleteBase<TEntity>(TEntity entity)
        {
            if (entity == null) throw new NullEntityException($"Exceção de entidade nula");

            long? id = (long?)entity.GetType().GetProperty("Id")?.GetValue(entity);

            if (!id.HasValue) throw new InvalidIdentifierException("Identificador com valor inválido");
        }
    }
}
