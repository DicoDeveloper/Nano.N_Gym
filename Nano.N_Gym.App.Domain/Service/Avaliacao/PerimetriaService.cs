﻿using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class PerimetriaService : GymBaseService<Perimetria>, IPerimetriaService
    {
        private readonly IPerimetriaRepository _repository;

        public PerimetriaService(IPerimetriaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Perimetria avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}