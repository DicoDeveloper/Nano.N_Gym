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
            builder.RegisterType<AvaliacaoAntropometricaService>().As<IAvaliacaoAntropometricaService>();
            builder.RegisterType<AvaliacaoBaseService>().As<IAvaliacaoBaseService>();
            builder.RegisterType<AvaliacaoCompletaService>().As<IAvaliacaoCompletaService>();
            builder.RegisterType<AvaliacaoComposicaoCorporalService>().As<IAvaliacaoComposicaoCorporalService>();
            builder.RegisterType<AvaliacaoIMCService>().As<IAvaliacaoIMCService>();
            builder.RegisterType<AvaliacaoPerimetriaService>().As<IAvaliacaoPerimetriaService>();
            builder.RegisterType<AvaliacaoRCQService>().As<IAvaliacaoRCQService>();
            builder.RegisterType<AvaliacaoRiscoCoronarianoService>().As<IAvaliacaoRiscoCoronarianoService>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<ColaboradorService>().As<IColaboradorService>();
            builder.RegisterType<ContratoService>().As<IContratoService>();
            builder.RegisterType<ExercicioService>().As<IExercicioService>();
            builder.RegisterType<ExercicioTreinoService>().As<IExercicioTreinoService>();
            builder.RegisterType<FichaAvaliacaoService>().As<IFichaAvaliacaoService>();
            builder.RegisterType<ModalidadeService>().As<IModalidadeService>();
            builder.RegisterType<PeriodoModalidadeService>().As<IPeriodoModalidadeService>();
            builder.RegisterType<TreinoService>().As<ITreinoService>();
            #endregion
        }
    }
}
