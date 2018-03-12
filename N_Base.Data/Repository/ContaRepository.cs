using System;
using N_Base.Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Infra;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Entity.Objects;

namespace N_Base.Data.Repository
{
    public class ContaRepository : IContaRepository
    {
        private IContext _context;

        public ContaRepository(IContext context) => _context = context;

        public bool Insert(Conta conta)
        {
            try
            {
                return _context.Insert(conta);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Conta.\nMensagem:{ex.Message}");
            }
        }
        public async Task<IEnumerable<Conta>> GetAll()
        {
            try
            {
                return await _context.GetContas();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Contas.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Conta> Get(long id)
        {
            try
            {
                return await _context.GetConta(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Conta.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}