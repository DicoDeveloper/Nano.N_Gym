using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Infra;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Entity.Objects;
using N_Base.Data.Interfaces;

namespace N_Base.Data.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private IContext _context { get; set; }

        public PessoaRepository(IContext context) => _context = context;

        public bool Insert(Pessoa pessoa)
        {
            try
            {
                return _context.Insert(pessoa);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Pessoa.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<Pessoa>> GetAll()
        {
            try
            {
                return await _context.GetPessoas();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Pessoas.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Pessoa> Get(long id)
        {
            try
            {
                return await _context.GetPessoa(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Pessoa.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}