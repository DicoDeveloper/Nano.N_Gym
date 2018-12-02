using Nano.N_Base.Data.Interface;
using Nano.N_Base.Model.Entity.Sistema;
using System.Data.Entity;

namespace Nano.N_Base.Data.Infra
{
    public class BaseEmpresaContext<TEntity> : BaseContext<TEntity>, IBaseContext<TEntity> where TEntity : class
    {
        public virtual DbSet<Empresa> Empresas { get; set; }

        public BaseEmpresaContext(string connectionName = "N_Base") : base(connectionName)
        {
        }

        public override bool Save(TEntity entity)
        {
            Empresa empresa = (Empresa)entity.GetType().GetProperty("Empresa").GetValue(entity);
            long idEmpresa = empresa.Id;
            entity.GetType().GetProperty("Empresa").SetValue(entity, Empresas.Find(idEmpresa));

            return base.Save(entity);
        }
    }
}
