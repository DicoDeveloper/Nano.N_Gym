using N_Base.Domain.Interfaces.Services;
using N_Gym.Application.Interfaces;
using N_Gym.Entity.Objects;

namespace N_Gym.Application.Services
{
    public class ExercicioServiceApp : ServiceBaseApp<Exercicio>, IExercicioServiceApp
    {
        public ExercicioServiceApp(IServiceBase<Exercicio> service) : base(service)
        {
        }
    }
}