using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Data.Infra;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Entity.Objects;
using N_Base.Data.Interfaces;

namespace N_Base.Data.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private IContext _context { get; set; }

        public UsuarioRepository(IContext context) => _context = context;

        public bool Insert(Usuario user)
        {
            try
            {
                return _context.Insert(user);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Usuario.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<IEnumerable<Usuario>> GetAll()
        {
            try
            {
                return await _context.GetUsuarios();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Usuarios.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Usuario> Get(long id)
        {
            try
            {
                return await _context.GetUsuario(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Usuario.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}