﻿using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ContratoService : BaseService<Contrato>, IContratoService
    {
        private readonly IContratoRepository _repository;

        public ContratoService(IContratoRepository repository, IBaseValidation<Contrato> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Contrato contrato)
        {
            // Executar verificacoes especificas
            return base.Save(contrato);
        }
    }
}
