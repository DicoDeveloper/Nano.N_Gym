﻿using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ModalidadeService : GymBaseService<Modalidade>, IModalidadeService
    {
        private readonly IModalidadeRepository _repository;

        public ModalidadeService(IModalidadeRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Modalidade modalidade)
        {
            // Executar verificacoes especificas
            return base.Save(modalidade);
        }
    }
}
