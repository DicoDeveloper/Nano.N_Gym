using Nano.N_Base.Model.Exception;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Validation
{
    internal static class ExercicioValidation
    {
        public static void Validate(Exercicio exercicio)
        {
            if (string.IsNullOrEmpty(exercicio.Nome))
                throw new InvalidOrNullRequiredPropertyException($"Propriedade {nameof(exercicio.Nome)} é obrigatória e não pode ser vasia");

            
        }
    }
}
