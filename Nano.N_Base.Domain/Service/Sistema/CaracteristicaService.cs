using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class CaracteristicaService : BaseService<Caracteristica>, ICaracteristicaService
    {
        private readonly ICaracteristicaRepository _repository;

        public CaracteristicaService(ICaracteristicaRepository repository, IBaseValidation<Caracteristica> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Caracteristica caracteristica)
        {
            // Executar verificacoes especificas
            return base.Save(caracteristica);
        }
    }
}
