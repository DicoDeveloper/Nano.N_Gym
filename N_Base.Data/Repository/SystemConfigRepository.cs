using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Infra;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Entity.Objects;
using N_Base.Data.Interfaces;

namespace N_Base.Data.Repository
{
    public class SystemConfigRepository : ISystemConfigRepository
    {
        private IContext _context { get; set; }

        public SystemConfigRepository(IContext context) => _context = context;

        public bool Insert(SystemConfig sys)
        {
            try
            {
                return _context.Insert(sys);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir SystemConfig.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<SystemConfig>> GetAll()
        {
            try
            {
                return await _context.GetSystemConfigs();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar SystemConfigs.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<SystemConfig> Get(long id)
        {
            try
            {
                return await _context.GetSystemConfig(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar SystemConfig.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}