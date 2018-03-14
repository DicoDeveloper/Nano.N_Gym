using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Services;
using N_Gym.Domain.Interfaces.Services;
using N_Gym.Entity.Objects;

namespace N_Gym.Domain.Services
{
    public class ContratoService : ServiceBase<Contrato>, IContratoService
    {
        public ContratoService(IRepositoryBase<Contrato> repository) : base(repository)
        {
        }
    }
}