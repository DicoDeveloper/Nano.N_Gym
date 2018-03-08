using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Infra;
using N_Base.Domain.Interfaces;
using N_Base.Entity.Objects;

namespace N_Base.Data.Repository
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private IContext _context { get; set; }

        public PagamentoRepository(IContext context) => _context = context;

        public bool Insert(Pagamento pagamento)
        {
            try
            {
                return _context.Insert(pagamento);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Pagamento.\nMensagem:{ex.Message}");
            }
        }
        public async Task<IEnumerable<Pagamento>> GetAll()
        {
            try
            {
                return await _context.GetPagamentos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Pagamentos.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Pagamento> Get(long id)
        {
            try
            {
                return await _context.GetPagamento(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Pagamento.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}