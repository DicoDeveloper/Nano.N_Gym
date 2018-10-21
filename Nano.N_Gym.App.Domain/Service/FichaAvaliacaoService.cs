using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class FichaAvaliacaoService : GymBaseService<FichaAvaliacao>, IFichaAvaliacaoService
    {
        private readonly IFichaAvaliacaoRepository _repository;

        public FichaAvaliacaoService(IFichaAvaliacaoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(FichaAvaliacao fichaAvaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(fichaAvaliacao);
        }
    }
}
