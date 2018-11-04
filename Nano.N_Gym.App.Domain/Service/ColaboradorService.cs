using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ColaboradorService : GymBaseService<Colaborador>, IColaboradorService
    {
        private readonly IColaboradorRepository _repository;

        public ColaboradorService(IColaboradorRepository repository) : base(repository)
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
