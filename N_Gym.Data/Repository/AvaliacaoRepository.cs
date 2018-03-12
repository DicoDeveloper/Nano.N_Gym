using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Infra;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Repository
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private IContextGym _context { get; set; }

        public AvaliacaoRepository(IContextGym context) => _context = context;

        public bool Insert(Avaliacao avaliacao)
        {
            try
            {
                return _context.Insert(avaliacao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Avaliação.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<Avaliacao>> GetAll()
        {
            try
            {
                return await _context.GetAvaliacoes();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Avaliações.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Avaliacao> Get(int id)
        {
            try
            {
                return await _context.GetAvaliacao(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Avaliação.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }        
    }
}