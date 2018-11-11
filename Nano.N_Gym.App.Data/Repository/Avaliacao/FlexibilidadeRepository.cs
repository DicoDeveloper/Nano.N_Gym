using Nano.N_Base.Data.Repository;
using Nano.N_Gym.App.Data.Interface.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Data.Repository.Avaliacao
{
    public class FlexibilidadeRepository : BaseRepository<Flexibilidade>, IFlexibilidadeRepository
    {
        private readonly IFlexibilidadeContext _context;

        public FlexibilidadeRepository(IFlexibilidadeContext context) : base(context)
        {
            _context = context;
        }
    }
}
