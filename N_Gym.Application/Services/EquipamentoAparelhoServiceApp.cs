using N_Base.Domain.Interfaces.Services;
using N_Gym.API.Interfaces;
using N_Gym.Entity.Objects;

namespace N_Gym.Application.Services
{
    public class EquipamentoAparelhoServiceApp : ServiceBaseApp<EquipamentoAparelho>, IEquipamentoAparelhoServiceApp
    {
        public EquipamentoAparelhoServiceApp(IServiceBase<EquipamentoAparelho> service) : base(service)
        {
        }
    }
}