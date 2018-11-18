using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class CapacidadeAerobicaEstimadaService : GymBaseService<CapacidadeAerobicaEstimada>, ICapacidadeAerobicaEstimadaService
    {
        private readonly ICapacidadeAerobicaEstimadaRepository _repository;

        public CapacidadeAerobicaEstimadaService(ICapacidadeAerobicaEstimadaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(CapacidadeAerobicaEstimada capacidadeAerobica)
        {
            // Executar verificacoes especificas
            return base.Save(capacidadeAerobica);
        }
    }
}
