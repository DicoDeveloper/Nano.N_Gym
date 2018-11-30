using Autofac;
using Nano.N_Base.Validation.Sistema;

namespace Nano.N_Base.Validation.Registration
{
    public class BaseValidationRegistration
    {
        public void Register(ref ContainerBuilder builder)
        {
            builder.RegisterType<AgendamentoBaseValidation>().AsImplementedInterfaces();
        }
    }
}
