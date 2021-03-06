﻿using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ProficaoService : BaseService<Proficao>, IProficaoService
    {
        private readonly IProficaoRepository _repository;

        public ProficaoService(IProficaoRepository repository, IBaseValidation<Proficao> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Proficao proficao)
        {
            // Executar verificacoes especificas
            return base.Save(proficao);
        }
    }
}
