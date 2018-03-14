using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Repository
{
    public class ModalidadeRepository : IModalidadeRepository
    {
        private IContextGym _context { get; set; }

        public ModalidadeRepository(IContextGym context) => _context = context;
        
        public bool Insert(Modalidade modalidade)
        {
            try
            {
                return _context.Insert(modalidade);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Modalidade.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<Modalidade>> GetAll()
        {
            try
            {
                return await _context.GetModalidades();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Modalidades.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Modalidade> Get(long id)
        {
            try
            {
                return await _context.GetModalidade(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Modalidade.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}