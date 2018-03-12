using System.Threading.Tasks;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;

namespace N_Base.Domain.Services
{
    public class AuditoriaService : ServiceBase<Auditoria>, IAuditoriaService
    {
        public AuditoriaService(IRepositoryBase<Auditoria> repository) : base(repository)
        {
        }
    }
}