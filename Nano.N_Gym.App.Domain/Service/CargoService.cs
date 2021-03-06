﻿using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class CargoService : BaseService<Cargo>, ICargoService
    {
        private readonly ICargoRepository _repository;

        public CargoService(ICargoRepository repository, IBaseValidation<Cargo> validation) : base(repository, validation)
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
