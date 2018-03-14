using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;

namespace N_Base.Domain.Services
{
    public class LojaService : ServiceBase<Loja>, ILojaService
    {
        public LojaService(IRepositoryBase<Loja> repository) : base(repository)
        {
        }
    }
}