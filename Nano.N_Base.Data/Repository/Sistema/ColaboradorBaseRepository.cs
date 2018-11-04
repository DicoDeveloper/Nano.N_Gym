using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class ColaboradorBaseRepository : BaseRepository<ColaboradorBase>, IColaboradorBaseRepository
    {
        private readonly IColaboradorBaseContext _context;

        public ColaboradorBaseRepository(IColaboradorBaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
