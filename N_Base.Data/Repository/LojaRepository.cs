using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Infra;
using N_Base.Domain.Interfaces;
using N_Base.Entity.Objects;

namespace N_Base.Data.Repository
{
    public class LojaRepository : ILojaRepository
    {
        private IContext _context { get; set; }

        public LojaRepository(IContext context) => _context = context;

        public bool Insert(Loja loja)
        {
            try
            {
                return _context.Insert(loja);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Endereço.\nMensagem:{ex.Message}");
            }
        }
        public async Task<IEnumerable<Loja>> GetAll()
        {
            try
            {
                return await _context.GetLojas();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Lojas.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Loja> Get(long id)
        {
            try
            {
                return await _context.GetLoja(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Loja.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}