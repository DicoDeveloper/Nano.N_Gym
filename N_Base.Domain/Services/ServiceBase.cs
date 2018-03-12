using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Interfaces.Services;

namespace N_Base.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository) => _repository = repository;

        public bool Insert(TEntity entity)
        {
            try
            {
                return _repository.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            try
            {
                return await _repository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<TEntity> Get(long id)
        {
            try
            {
                return await _repository.Get(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}