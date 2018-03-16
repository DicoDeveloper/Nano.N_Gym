using N_Base.Domain.Interfaces.Services;
using N_Gym.Application.Interfaces;
using N_Gym.Entity.Objects;

namespace N_Gym.Application.Services
{
    public class ModalidadeServiceApp : ServiceBaseApp<Modalidade>, IModalidadeServiceApp
    {
        public ModalidadeServiceApp(IServiceBase<Modalidade> service) : base(service)
        {
        }
    }
}