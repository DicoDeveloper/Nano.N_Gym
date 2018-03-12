using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Repository
{
    public class FichaAvaliacaoClienteRepository : IFichaAvaliacaoClienteRepository
    {
        private IContextGym _context { get; set; }

        public FichaAvaliacaoClienteRepository(IContextGym context) => _context = context;
        
        public bool Insert(FichaAvaliacaoCliente fichaAva)
        {
            try
            {
                return _context.Insert(fichaAva);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Ficha Avaliação Cliente.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<FichaAvaliacaoCliente>> GetAll()
        {
            try
            {
                return await _context.GetFichasAvaliacoesClientes();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Fichas Avaliações Clientes.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<FichaAvaliacaoCliente> Get(int id)
        {
            try
            {
                return await _context.GetFichaAvaliacaoCliente(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Ficha Avaliação Cliente.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}