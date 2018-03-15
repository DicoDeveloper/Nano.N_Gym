using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Domain.Interfaces.Services;
using N_Gym.API.Interfaces;

namespace N_Gym.Application.Services
{
    public class ServiceBaseApp<TEntity> : IServiceBaseApp<TEntity> where TEntity : class
    {
        private IServiceBase<TEntity> _service;

        public ServiceBaseApp(IServiceBase<TEntity> service) => _service = service;

        public bool Insert(TEntity entity)
        {
            try
            {
                return _service.Insert(entity);
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
                return await _service.GetAll();
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
                return await _service.Get(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}