using Autofac;
using Nano.N_Base.Data.Registration;
using Nano.N_Base.Domain.Registration;
using Nano.N_Base.Validation.Registration;
using Nano.N_Gym.App.Data.Registration;
using Nano.N_Gym.App.Domain.Registration;
using Nano.N_Gym.App.Validation.Registration;

namespace Nano.N_IoC
{
    public class IoC
    {
        private readonly IContainer _container;

        public IoC()
        {
            ContainerBuilder builder = CreateAndRegisterBuilder();
            _container = builder.Build();
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        private ContainerBuilder CreateAndRegisterBuilder()
        {
            ContainerBuilder builder = new ContainerBuilder();

            new BaseDataRegistration().Register(ref builder);
            new BaseDomainRegistration().Register(ref builder);
            new BaseValidationRegistration().Register(ref builder);
            new GymDataRegistration().Register(ref builder);
            new GymDomainRegistration().Register(ref builder);
            new GymValidationRegistration().Register(ref builder);

            return builder;
        }
    }
}
