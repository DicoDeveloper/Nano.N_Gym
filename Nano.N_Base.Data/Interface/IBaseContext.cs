﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Nano.N_Base.Data.Interface
{
    public interface IBaseContext<TEntity> : IDisposable where TEntity : class
    {
        bool Save(TEntity entity);
        IQueryable<TEntity> GetAll();
        TEntity GetById(long id);
        bool Delete(long id);
        bool DeleteRange(IEnumerable<TEntity> entities);
        bool Inactivate(long id);
    }
}
