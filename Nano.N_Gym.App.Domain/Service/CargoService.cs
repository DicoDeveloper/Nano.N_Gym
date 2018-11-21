using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class CargoService : GymBaseService<Cargo>, ICargoService
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
