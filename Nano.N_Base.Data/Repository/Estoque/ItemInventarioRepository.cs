using Nano.N_Base.Data.Interface.Estoque;
using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Data.Repository.Estoque
{
    public class ItemInventarioRepository : BaseRepository<ItemInventario>, IItemInventarioRepository
    {
        private readonly IItemInventarioContext _context;

        public ItemInventarioRepository(IItemInventarioContext context) : base(context)
        {
            _context = context;
        }
    }
}
