using Autofac;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Domain.Service;
using Nano.N_Gym.App.Domain.Service.Avaliacao;

namespace Nano.N_Gym.App.Domain.Registration
{
    public static class GymDomainRegistration
    {
        public static void Register(ref ContainerBuilder builder)
        {
            #region Services
            builder.RegisterType<AnamneseService>().As<IAnamneseService>();
            builder.RegisterType<AparelhoService>().As<IAparelhoService>();
            builder.RegisterType<AvaliacaoAntropometricaService>().As<IAvaliacaoAntropometricaService>();
            builder.RegisterType<AvaliacaoBaseService>().As<IAvaliacaoBaseService>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<ColaboradorService>().As<IColaboradorService>();
            builder.RegisterType<ComposicaoCorporalService>().As<IComposicaoCorporalService>();
            builder.RegisterType<ContratoService>().As<IContratoService>();
            builder.RegisterType<ExercicioService>().As<IExercicioService>();
            builder.RegisterType<ExercicioTreinoService>().As<IExercicioTreinoService>();
            builder.RegisterType<FlexibilidadeService>().As<IFlexibilidadeService>();
            builder.RegisterType<ForcaResistenciaMuscularService>().As<IForcaResistenciaMuscularService>();
            builder.RegisterType<IMCService>().As<IIMCService>();
            builder.RegisterType<ModalidadeService>().As<IModalidadeService>();
            builder.RegisterType<PARQService>().As<IPARQService>();
            builder.RegisterType<PerimetriaService>().As<IPerimetriaService>();
            builder.RegisterType<PeriodoModalidadeService>().As<IPeriodoModalidadeService>();
            builder.RegisterType<QuestionarioAhaService>().As<IQuestionarioAhaService>();
            builder.RegisterType<RCQService>().As<IRCQService>();
            builder.RegisterType<RiscoCoronarianoService>().As<IRiscoCoronarianoService>();
            builder.RegisterType<TreinoService>().As<ITreinoService>();
            #endregion
        }
    }
}
