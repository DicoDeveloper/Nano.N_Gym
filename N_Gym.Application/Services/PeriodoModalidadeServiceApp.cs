using N_Base.Domain.Interfaces.Services;
using N_Gym.Application.Interfaces;
using N_Gym.Entity.Objects;

namespace N_Gym.Application.Services
{
    public class PeriodoModalidadeServiceApp : ServiceBaseApp<PeriodoModalidade>, IPeriodoModalidadeServiceApp
    {
        public PeriodoModalidadeServiceApp(IServiceBase<PeriodoModalidade> service) : base(service)
        {
        }
    }
}