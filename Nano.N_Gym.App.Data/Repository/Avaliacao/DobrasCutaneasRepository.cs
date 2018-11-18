using Nano.N_Base.Data.Repository;
using Nano.N_Gym.App.Data.Interface.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Data.Repository.Avaliacao
{
    public class DobrasCutaneasRepository : BaseRepository<DobrasCutaneas>, IDobrasCutaneasRepository
    {
        private readonly IDobrasCutaneasContext _context;

        public DobrasCutaneasRepository(IDobrasCutaneasContext context) : base(context)
        {
            _context = context;
        }
    }
}
