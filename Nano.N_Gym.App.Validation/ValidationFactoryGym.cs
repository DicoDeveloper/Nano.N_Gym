using Nano.N_Gym.App.Model.Entity;
using Nano.N_Gym.App.Model.Entity.Avaliacao;
using Nano.N_Gym.App.Validation.Avaliacao;
using static Nano.N_Base.Validation.ValidationFactoryBase;

namespace Nano.N_Gym.App.Validation
{
    public static class ValidationFactoryGym
    {
        public static void Validate<TEntity>(TEntity entity)
        {
            switch (entity)
            {
                case Anamnese anamnese when anamnese.GetType() == entity.GetType():
                    AnamneseValidation.Validate(anamnese);
                    break;
                case Exercicio exercicio when exercicio.GetType() == entity.GetType():
                    ExercicioValidation.Validate(exercicio);
                    break;
                default:
                    ValidateBase(entity);
                    break;
            }
        }

        public static void ValidateId(long id)
        {
            ValidateIdBase(id);
        }

        public static void ValidateDelete<TEntity>(TEntity entity)
        {
            ValidateDeleteBase(entity);
        }
    }
}
