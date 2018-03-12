using N_Base.Data.Infra;
using N_Base.Data.Interfaces;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Entity.Objects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace N_Base.Data.Repository
{
    public class AuditoriaRepository : IAuditoriaRepository
    {
        private IContext _context { get; set; }

        public AuditoriaRepository(IContext context) => _context = context;

        public bool Insert(Auditoria auditoria)
        {
            try
            {
                return _context.Insert(auditoria);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Inserir Auditoria.\nMensagem:{ex.Message}");
            }
        }        
        public async Task<IEnumerable<Auditoria>> GetAll()
        {
            try
            {
                return await _context.GetAuditorias();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Auditorias.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
        public async Task<Auditoria> Get(long id)
        {
            try
            {
                return await _context.GetAuditoria(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao Buscar Auditoria.\nMensagem:{ex.Message}");
            }
            finally
            {
                _context.Dispose();
            }
        }
    }
}