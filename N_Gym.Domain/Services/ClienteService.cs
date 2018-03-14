using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Services;
using N_Gym.Domain.Interfaces.Services;
using N_Gym.Entity.Objects;

namespace N_Gym.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        public ClienteService(IRepositoryBase<Cliente> repository) : base(repository)
        {
        }
    }
}