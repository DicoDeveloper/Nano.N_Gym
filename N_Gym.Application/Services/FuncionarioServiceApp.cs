using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;
using N_Gym.Application.Interfaces;

namespace N_Gym.Application.Services
{
    public class FuncionarioServiceApp : ServiceBaseApp<Funcionario>, IFuncionarioServiceApp
    {
        public FuncionarioServiceApp(IServiceBase<Funcionario> service) : base(service)
        {
        }
    }
}