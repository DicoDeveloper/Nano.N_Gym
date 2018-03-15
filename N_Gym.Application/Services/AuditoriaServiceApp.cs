using System.Collections.Generic;
using System.Threading.Tasks;
using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;
using N_Gym.API.Interfaces;

namespace N_Gym.Application.Services
{
    public class AuditoriaServiceApp : ServiceBaseApp<Auditoria>, IAuditoriaServiceApp
    {
        public AuditoriaServiceApp(IServiceBase<Auditoria> service) : base(service)
        {
        }
    }
}