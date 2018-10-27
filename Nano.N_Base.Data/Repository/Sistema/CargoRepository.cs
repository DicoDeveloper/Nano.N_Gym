using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
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
