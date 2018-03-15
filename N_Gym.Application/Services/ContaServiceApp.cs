using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;
using N_Gym.API.Interfaces;

namespace N_Gym.Application.Services
{
    public class ContaServiceApp : ServiceBaseApp<Conta>, IContaServiceApp
    {
        public ContaServiceApp(IServiceBase<Conta> service) : base(service)
        {
        }
    }
}