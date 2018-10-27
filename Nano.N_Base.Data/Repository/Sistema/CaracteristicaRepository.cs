using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
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
