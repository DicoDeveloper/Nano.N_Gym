using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Repository
{
    public class EquipamentoAparelhoRepository : IEquipamentoAparelhoRepository
    {
        private IContextGym _context { get; set; }

        public EquipamentoAparelhoRepository(IContextGym context) => _context = context;
        
        public bool Insert(EquipamentoAparelho equipApar)
        {
            try
            {
                return _context.Insert(equipApar);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Equipamento Aparelho.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<EquipamentoAparelho>> GetAll()
        {
            try
            {
                return await _context.GetEquipamentosAparelhos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Equipamentos Aparelhos.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<EquipamentoAparelho> Get(long id)
        {
            try
            {
                return await _context.GetEquipamentoAparelho(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Equipamento Aparelho.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}