using N_Base.Domain.Interfaces.Services;
using N_Gym.Application.Interfaces;
using N_Gym.Entity.Objects;

namespace N_Gym.Application.Services
{
    public class FichaAvaliacaoClienteServiceApp : ServiceBaseApp<FichaAvaliacaoCliente>, IFichaAvaliacaoClienteServiceApp
    {
        public FichaAvaliacaoClienteServiceApp(IServiceBase<FichaAvaliacaoCliente> service) : base(service)
        {
        }
    }
}