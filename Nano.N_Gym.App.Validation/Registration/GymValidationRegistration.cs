using Autofac;
using Nano.N_Gym.App.Validation.Avaliacao;

namespace Nano.N_Gym.App.Validation.Registration
{
    public class GymValidationRegistration
    {
        public void Register(ref ContainerBuilder builder)
        {
            builder.RegisterType<AgendamentoValidation>().AsImplementedInterfaces();
            builder.RegisterType<AnamneseValidation>().AsImplementedInterfaces();
            builder.RegisterType<ExercicioValidation>().AsImplementedInterfaces();
        }
    }
}
