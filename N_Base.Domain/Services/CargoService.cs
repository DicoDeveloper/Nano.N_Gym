using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;

namespace N_Base.Domain.Services
{
    public class CargoService : ServiceBase<Cargo>, ICargoService
    {
        public CargoService(IRepositoryBase<Cargo> repository) : base(repository)
        {
        }
    }
}