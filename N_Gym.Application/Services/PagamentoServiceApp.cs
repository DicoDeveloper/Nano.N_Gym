using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;
using N_Gym.Application.Interfaces;

namespace N_Gym.Application.Services
{
    public class PagamentoServiceApp : ServiceBaseApp<Pagamento>, IPagamentoServiceApp
    {
        public PagamentoServiceApp(IServiceBase<Pagamento> service) : base(service)
        {
        }
    }
}