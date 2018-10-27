using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class CargoService : BaseService<Cargo>, ICargoService
    {
        private readonly ICargoRepository _repository;

        public CargoService(ICargoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Cargo cargo)
        {
            // Executar verificacoes especificas
            return base.Save(cargo);
        }
    }
}
