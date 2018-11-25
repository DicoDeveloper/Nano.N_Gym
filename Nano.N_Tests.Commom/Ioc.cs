using Autofac;
using Nano.N_Base.Data.Registration;
using Nano.N_Base.Domain.Registration;
using Nano.N_Gym.App.Data.Registration;
using Nano.N_Gym.App.Domain.Registration;

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

            BaseDataRegistration.Register(ref builder);
            BaseDomainRegistration.Register(ref builder);
            GymDataRegistration.Register(ref builder);
            GymDomainRegistration.Register(ref builder);

            return builder;
        }
    }
}
