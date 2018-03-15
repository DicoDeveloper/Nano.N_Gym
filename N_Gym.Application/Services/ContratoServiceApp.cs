using N_Base.Domain.Interfaces.Services;
using N_Gym.API.Interfaces;
using N_Gym.Entity.Objects;

namespace N_Gym.Application.Services
{
    public class ContratoServiceApp : ServiceBaseApp<Contrato>, IContratoServiceApp
    {
        public ContratoServiceApp(IServiceBase<Contrato> service) : base(service)
        {
        }
    }
}