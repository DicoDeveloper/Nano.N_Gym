using Nano.N_Base.Data.Interface;
using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Data.Repository
{
    public class CaracteristicaRepository : BaseRepository<Caracteristica>, ICaracteristicaRepository
    {
        private readonly ICaracteristicaContext _context;

        public CaracteristicaRepository(ICaracteristicaContext context) : base(context)
        {
            _context = context;
        }
    }
}
