using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Infra;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Entity.Objects;
using N_Base.Data.Interfaces;

namespace N_Base.Data.Repository
{
    public class PermissaoUsuarioRepository : IPermissaoUsuarioRepository
    {
        private IContext _context { get; set; }

        public PermissaoUsuarioRepository(IContext context) => _context = context;

        public bool Insert(PermissaoUsuario permissao)
        {
            try
            {
                return _context.Insert(permissao);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Permissao.\nMensagem:{ex.Message}");
            }
        }
        public async Task<IEnumerable<PermissaoUsuario>> GetAll()
        {
            try
            {
                return await _context.GetPermissoes();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Permissoes.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<PermissaoUsuario> Get(long id)
        {
            try
            {
                return await _context.GetPermissao(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Permissao.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}