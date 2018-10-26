﻿using Nano.N_Base.Data.Interface;
using System.Data.Entity;
using System.Linq;

namespace Nano.N_Base.Data.Infra
{
    public class BaseContext<TEntity> : DbContext, IContext<TEntity> where TEntity : class
    {
        public DbSet<TEntity> Entities { get; set; }

        public BaseContext(string connectionName = "N_Base") : base("Name=" + connectionName)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<BaseContext<TEntity>>());
            Database.Initialize(false);
        }

        public bool Save(TEntity entity)
        {
            Entities.Add(entity);
            if ((long)entity.GetType().GetProperty("Id").GetValue(entity) == 0)
                Entry(entity).State = EntityState.Modified;

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

        public bool Delete(long id)
        {
            Entities.Remove(Entities.Find(id));

            return SaveChanges() > 0;
        }
    }
}
