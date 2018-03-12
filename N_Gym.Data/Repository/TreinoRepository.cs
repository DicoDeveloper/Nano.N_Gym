using System.Collections.Generic;
using System.Threading.Tasks;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Entity.Objects;

namespace N_Gym.Data.Repository
{
    public class TreinoRepository : ITreinoRepository
    {
        private IContextGym _context { get; set; }

        public TreinoRepository(IContextGym context) => _context = context;

        public bool Insert(Treino entity)
        {
            throw new System.NotImplementedException();
        }
        public Task<IEnumerable<Treino>> GetAll()
        {
            throw new System.NotImplementedException();
        }
        public Task<Treino> Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}