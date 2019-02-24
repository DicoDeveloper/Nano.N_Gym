using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Model.Exception;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Validation
{
    public class BaseEmpresaValidation<TEntity> : BaseValidation<TEntity>, IBaseValidation<TEntity> where TEntity : class
    {
        public override void Validate(TEntity entity)
        {
            base.Validate(entity);

            Empresa empresa = (Empresa)entity.GetType().GetProperty("Empresa").GetValue(entity);

            if (empresa == null)
                throw new NullEntityException("Empresa precisa ser vinculada ao registro");
        }
    }
}
