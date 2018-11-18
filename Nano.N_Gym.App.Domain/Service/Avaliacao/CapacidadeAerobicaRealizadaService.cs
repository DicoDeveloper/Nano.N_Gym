﻿using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class CapacidadeAerobicaRealizadaService : GymBaseService<CapacidadeAerobicaRealizada>, ICapacidadeAerobicaRealizadaService
    {
        private readonly ICapacidadeAerobicaRealizadaRepository _repository;

        public CapacidadeAerobicaRealizadaService(ICapacidadeAerobicaRealizadaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(CapacidadeAerobicaRealizada capacidadeAerobica)
        {
            // Executar verificacoes especificas
            return base.Save(capacidadeAerobica);
        }
    }
}