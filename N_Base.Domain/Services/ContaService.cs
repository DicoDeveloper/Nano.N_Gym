using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;

namespace N_Base.Domain.Services
{
    public class ContaService : ServiceBase<Conta>, IContaService
    {
        public ContaService(IRepositoryBase<Conta> repository) : base(repository)
        {
        }
    }
}