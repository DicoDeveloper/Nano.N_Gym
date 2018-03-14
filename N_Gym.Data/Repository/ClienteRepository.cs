using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private IContextGym _context { get; set; }

        public ClienteRepository(IContextGym context) => _context = context;
        
        public bool Insert(Cliente cliente)
        {
            try
            {
                return _context.Insert(cliente);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Cliente.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<Cliente>> GetAll()
        {
            try
            {
                return await _context.GetClientes();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Clientes.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Cliente> Get(long id)
        {
            try
            {
                return await _context.GetCliente(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Cliente.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}