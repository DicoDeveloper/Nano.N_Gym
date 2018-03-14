using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;

namespace N_Base.Domain.Services
{
    public class SystemConfigService : ServiceBase<SystemConfig>, ISystemConfigService
    {
        public SystemConfigService(IRepositoryBase<SystemConfig> repository) : base(repository)
        {
        }
    }
}