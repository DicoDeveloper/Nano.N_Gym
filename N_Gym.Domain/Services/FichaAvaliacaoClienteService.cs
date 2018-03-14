using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Services;
using N_Gym.Domain.Interfaces.Services;
using N_Gym.Entity.Objects;

namespace N_Gym.Domain.Services
{
    public class FichaAvaliacaoClienteService : ServiceBase<FichaAvaliacaoCliente>, IFichaAvaliacaoClienteService
    {
        public FichaAvaliacaoClienteService(IRepositoryBase<FichaAvaliacaoCliente> repository) : base(repository)
        {
        }
    }
}