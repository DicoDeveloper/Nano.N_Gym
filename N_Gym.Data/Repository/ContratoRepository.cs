using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Base.Data.Repository
{
    public class ContratoRepository : IContratoRepository
    {
        private IContextGym _context { get; set; }

        public ContratoRepository(IContextGym context) => _context = context;
        
        public bool Insert(Contrato contrato)
        {
            try
            {
                return _context.Insert(contrato);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Contrato.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<Contrato>> GetAll()
        {
            try
            {
                return await _context.GetContratos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Contratos.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Contrato> Get(int id)
        {
            try
            {
                return await _context.GetContrato(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Contrato.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}