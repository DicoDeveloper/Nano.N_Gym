using Autofac;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Domain.Service;

namespace Nano.N_Gym.App.Domain.Registration
{
    public static class GymDomainRegistration
    {
        public static void Register(ref ContainerBuilder builder)
        {
            #region Services
            builder.RegisterType<AparelhoService>().As<IAparelhoService>();
            builder.RegisterType<AvaliacaoService>().As<IAvaliacaoService>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<ContratoService>().As<IContratoService>();
            builder.RegisterType<ExercicioService>().As<IExercicioService>();
            builder.RegisterType<FichaAvaliacaoService>().As<IFichaAvaliacaoService>();
            builder.RegisterType<ModalidadeService>().As<IModalidadeService>();
            builder.RegisterType<PeriodoModalidadeService>().As<IPeriodoModalidadeService>();
            builder.RegisterType<TreinoService>().As<ITreinoService>();
            #endregion
        }
    }
}
