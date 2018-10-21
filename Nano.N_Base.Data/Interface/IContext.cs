﻿using System.Linq;

namespace Nano.N_Base.Data.Interface
{
    public interface IContext<TEntity> where TEntity : class
    {
        bool Save(TEntity entity);
        IQueryable<TEntity> GetAll();
        TEntity GetById(long id);
        bool Delete(long id);
    }
}