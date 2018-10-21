using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Domain.Service
{
    internal class CaracteristicaService : BaseService<Caracteristica>, ICaracteristicaService
    {
        private readonly ICaracteristicaRepository _repository;

        public CaracteristicaService(ICaracteristicaRepository repository) : base(repository)
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
