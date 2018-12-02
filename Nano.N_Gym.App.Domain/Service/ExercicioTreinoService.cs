using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ExercicioTreinoService : BaseService<ExercicioTreino>, IExercicioTreinoService
    {
        private readonly IExercicioTreinoRepository _repository;

        public ExercicioTreinoService(IExercicioTreinoRepository repository, IBaseValidation<ExercicioTreino> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(ExercicioTreino ExercicioTreino)
        {
            // Executar verificacoes especificas
            return base.Save(ExercicioTreino);
        }
    }
}
