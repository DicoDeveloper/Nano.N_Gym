using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Infra;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Data.Interfaces;
using N_Base.Entity.Objects;

namespace N_Base.Data.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private IContext _context { get; set; }

        public FuncionarioRepository(IContext context) => _context = context;

        public bool Insert(Funcionario funcionario)
        {
            try
            {
                return _context.Insert(funcionario);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Funcionario.\nMensagem:{ex.Message}");
            }
        }
        public async Task<IEnumerable<Funcionario>> GetAll()
        {
            try
            {
                return await _context.GetFuncionarios();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Funcionarios.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Funcionario> Get(long id)
        {
            try
            {
                return await _context.GetFuncionario(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Funcionario.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}