using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class AnamneseService : GymBaseService<Anamnese>, IAnamneseService
    {
        private readonly IAnamneseRepository _repository;

        public AnamneseService(IAnamneseRepository repository, IBaseValidation<Anamnese> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Anamnese anamnese)
        {
            // Executar verificacoes especificas
            return base.Save(anamnese);
        }
    }
}
