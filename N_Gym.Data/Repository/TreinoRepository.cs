using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Repository
{
    public class TreinoRepository : ITreinoRepository
    {
        private IContextGym _context { get; set; }

        public TreinoRepository(IContextGym context) => _context = context;

        public bool Insert(Treino treino)
        {
            try
            {
                return _context.Insert(treino);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Treino.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<Treino>> GetAll()
        {
            try
            {
                return await _context.GetTreinos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Treinos.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Treino> Get(long id)
        {
            try
            {
                return await _context.GetTreino(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Treino.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}