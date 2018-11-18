using Nano.N_Base.Data.Repository;
using Nano.N_Gym.App.Data.Interface.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Data.Repository.Avaliacao
{
    public class MassaMuscularRepository : BaseRepository<MassaMuscular>, IMassaMuscularRepository
    {
        private readonly IMassaMuscularContext _context;

        public MassaMuscularRepository(IMassaMuscularContext context) : base(context)
        {
            _context = context;
        }
    }
}
