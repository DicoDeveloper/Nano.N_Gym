using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Repository
{
    public class ExercicioRepository : IExercicioRepository
    {
        private IContextGym _context { get; set; }

        public ExercicioRepository(IContextGym context) => _context = context;
        
        public bool Insert(Exercicio exercicio)
        {
            try
            {
                return _context.Insert(exercicio);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Exercicio.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<Exercicio>> GetAll()
        {
            try
            {
                return await _context.GetExercicios();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Exercicios.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Exercicio> Get(int id)
        {
            try
            {
                return await _context.GetExercicio(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Exercicio.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}