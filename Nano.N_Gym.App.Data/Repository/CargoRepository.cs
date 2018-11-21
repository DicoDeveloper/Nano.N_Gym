using Nano.N_Base.Data.Repository;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Data.Repository
{
    public class CargoRepository : BaseRepository<Cargo>, ICargoRepository
    {
        private readonly ICargoContext _context;

        public CargoRepository(ICargoContext context) : base(context)
        {
            _context = context;
        }
    }
}
