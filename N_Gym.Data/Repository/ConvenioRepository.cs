using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Repository
{
    public class ConvenioRepository : IConvenioRepository
    {
        private IContextGym _context { get; set; }

        public ConvenioRepository(IContextGym context) => _context = context;
        
        public bool Insert(Convenio convenio)
        {
            try
            {
                return _context.Insert(convenio);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Convenio.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<Convenio>> GetAll()
        {
            try
            {
                return await _context.GetConvenios();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Convenios.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Convenio> Get(long id)
        {
            try
            {
                return await _context.GetConvenio(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Convenio.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}