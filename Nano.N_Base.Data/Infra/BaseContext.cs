using Nano.N_Base.Data.Interface;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Nano.N_Base.Data.Infra
{
    public class BaseContext<TEntity> : DbContext, IBaseContext<TEntity> where TEntity : class
    {
        public DbSet<TEntity> Entities { get; set; }

        public BaseContext(string connectionName = "N_Base") : base("Name=" + connectionName)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BaseContext<TEntity>>());
            Database.Initialize(false);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConve‌​ntion>();
        }

        public bool Save(TEntity entity)
        {
            Entities.Add(entity);
            if ((long)entity.GetType().GetProperty("Id").GetValue(entity) < 0)
                Entry(entity).State = EntityState.Modified;
            else
                entity.GetType().GetProperty("Ativo").SetValue(entity, true);

            return SaveChanges() > 0;
        }

        public IQueryable<TEntity> GetAll()
        {
            return Entities.AsQueryable();
        }

        public TEntity GetById(long id)
        {
            return Entities.Find(id);
        }

        public bool Delete(TEntity entity)
        {
            Entities.Remove(entity);

            return SaveChanges() > 0;
        }

        public bool Delete(long id)
        {
            Entities.Remove(Entities.Find(id));

            return SaveChanges() > 0;
        }

        public bool DeleteRange(IEnumerable<TEntity> entities)
        {
            Entities.RemoveRange(entities);

            return SaveChanges() > 0;
        }
    }
}
