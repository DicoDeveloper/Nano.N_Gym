using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
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
