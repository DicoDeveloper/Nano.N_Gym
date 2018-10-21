using Nano.N_Base.Data.Interface;
using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Data.Repository
{
    public class CaracteristicaPessoaRepository : BaseRepository<CaracteristicaPessoa>, ICaracteristicaPessoaRepository
    {
        private readonly ICaracteristicaPessoaContext _context;

        public CaracteristicaPessoaRepository(ICaracteristicaPessoaContext context) : base(context)
        {
            _context = context;
        }
    }
}
