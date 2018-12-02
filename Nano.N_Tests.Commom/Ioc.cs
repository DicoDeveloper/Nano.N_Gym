using Autofac;
using Nano.N_Base.Data.Registration;
using Nano.N_Base.Domain.Registration;
using Nano.N_Base.Model.Interface;
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

            AutofacInstanceContextMode autoFacMode = AutofacInstanceContextMode.PerCall;

            new BaseDataRegistration().Register(ref builder, autoFacMode);
            new BaseDomainRegistration().Register(ref builder, autoFacMode);
            new BaseValidationRegistration().Register(ref builder, autoFacMode);
            new GymDataRegistration().Register(ref builder, autoFacMode);
            new GymDomainRegistration().Register(ref builder, autoFacMode);
            new GymValidationRegistration().Register(ref builder, autoFacMode);

            return builder;
        }
    }
}
