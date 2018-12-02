using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class CapacidadeAerobicaEstimadaService : BaseService<CapacidadeAerobicaEstimada>, ICapacidadeAerobicaEstimadaService
    {
        private readonly ICapacidadeAerobicaEstimadaRepository _repository;

        public CapacidadeAerobicaEstimadaService(ICapacidadeAerobicaEstimadaRepository repository, IBaseValidation<CapacidadeAerobicaEstimada> validation) : base(repository, validation)
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
