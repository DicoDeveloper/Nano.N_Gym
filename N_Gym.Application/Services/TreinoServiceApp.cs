using N_Base.Domain.Interfaces.Services;
using N_Gym.Application.Interfaces;
using N_Gym.Entity.Objects;

namespace N_Gym.Application.Services
{
    public class TreinoServiceApp : ServiceBaseApp<Treino>, ITreinoServiceApp
    {
        public TreinoServiceApp(IServiceBase<Treino> service) : base(service)
        {
        }
    }
}