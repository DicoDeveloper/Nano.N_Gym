using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;
using N_Gym.Application.Interfaces;

namespace N_Gym.Application.Services
{
    public class SystemConfigServiceApp : ServiceBaseApp<SystemConfig>, ISystemConfigServiceApp
    {
        public SystemConfigServiceApp(IServiceBase<SystemConfig> service) : base(service)
        {
        }
    }
}