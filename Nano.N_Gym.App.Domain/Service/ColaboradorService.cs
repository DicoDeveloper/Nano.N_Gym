﻿using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ColaboradorService : BaseService<Colaborador>, IColaboradorService
    {
        private readonly IColaboradorRepository _repository;

        public ColaboradorService(IColaboradorRepository repository, IBaseValidation<Colaborador> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Colaborador colaborador)
        {
            // Executar verificacoes especificas
            return base.Save(colaborador);
        }
    }
}
