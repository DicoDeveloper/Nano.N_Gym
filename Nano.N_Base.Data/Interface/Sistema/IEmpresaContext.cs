using Nano.N_Base.Model.Entity.Sistema;
using System.Data.Entity.Infrastructure;

namespace Nano.N_Base.Data.Interface.Sistema
{
    public interface IEmpresaContext : IBaseContext<Empresa>
    {
        DbEntityEntry Entry(object entity);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
