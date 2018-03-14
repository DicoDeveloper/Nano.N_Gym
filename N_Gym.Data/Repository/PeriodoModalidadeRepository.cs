using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Repository
{
    public class PeriodoModalidadeRepository : IPeriodoModalidadeRepository
    {
        private IContextGym _context { get; set; }

        public PeriodoModalidadeRepository(IContextGym context) => _context = context;

        public bool Insert(PeriodoModalidade preiodo)
        {
            try
            {
                return _context.Insert(preiodo);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Periodo.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<PeriodoModalidade>> GetAll()
        {
            try
            {
                return await _context.GetPeriodos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Periodos Modalidades.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<PeriodoModalidade> Get(long id)
        {
            try
            {
                return await _context.GetPeriodo(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Periodo Modalidade.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}