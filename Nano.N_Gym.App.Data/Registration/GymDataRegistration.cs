using Autofac;
using Nano.N_Gym.App.Data.Infra;
using Nano.N_Gym.App.Data.Infra.Avaliacao;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Data.Interface.Avaliacao;
using Nano.N_Gym.App.Data.Repository;
using Nano.N_Gym.App.Data.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;

namespace Nano.N_Gym.App.Data.Registration
{
    public static class GymDataRegistration
    {
        public static void Register(ref ContainerBuilder builder)
        {
            #region Repositories
            builder.RegisterType<AnamneseRepository>().As<IAnamneseRepository>();
            builder.RegisterType<AparelhoRepository>().As<IAparelhoRepository>();
            builder.RegisterType<AvaliacaoAntropometricaRepository>().As<IAvaliacaoAntropometricaRepository>();
            builder.RegisterType<AvaliacaoBaseRepository>().As<IAvaliacaoBaseRepository>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<ColaboradorRepository>().As<IColaboradorRepository>();
            builder.RegisterType<ComposicaoCorporalRepository>().As<IComposicaoCorporalRepository>();
            builder.RegisterType<ContratoRepository>().As<IContratoRepository>();
            builder.RegisterType<ExercicioRepository>().As<IExercicioRepository>();
            builder.RegisterType<ExercicioTreinoRepository>().As<IExercicioTreinoRepository>();
            builder.RegisterType<FlexibilidadeRepository>().As<IFlexibilidadeRepository>();
            builder.RegisterType<ForcaResistenciaMuscularRepository>().As<IForcaResistenciaMuscularRepository>();
            builder.RegisterType<IMCRepository>().As<IIMCRepository>();
            builder.RegisterType<ModalidadeRepository>().As<IModalidadeRepository>();
            builder.RegisterType<PARQRepository>().As<IPARQRepository>();
            builder.RegisterType<PerimetriaRepository>().As<IPerimetriaRepository>();
            builder.RegisterType<PeriodoModalidadeRepository>().As<IPeriodoModalidadeRepository>();
            builder.RegisterType<QuestionarioAhaRepository>().As<IQuestionarioAhaRepository>();
            builder.RegisterType<RCQRepository>().As<IRCQRepository>();
            builder.RegisterType<RiscoCoronarianoRepository>().As<IRiscoCoronarianoRepository>();
            builder.RegisterType<TreinoRepository>().As<ITreinoRepository>();
            #endregion

            #region Contexties
            builder.RegisterType<AnamneseContext>().As<IAnamneseContext>();
            builder.RegisterType<AparelhoContext>().As<IAparelhoContext>();
            builder.RegisterType<AvaliacaoAntropometricaContext>().As<IAvaliacaoAntropometricaContext>();
            builder.RegisterType<AvaliacaoBaseContext>().As<IAvaliacaoBaseContext>();
            builder.RegisterType<ClienteContext>().As<IClienteContext>();
            builder.RegisterType<ColaboradorContext>().As<IColaboradorContext>();
            builder.RegisterType<ComposicaoCorporalContext>().As<IComposicaoCorporalContext>();
            builder.RegisterType<ContratoContext>().As<IContratoContext>();
            builder.RegisterType<ExercicioContext>().As<IExercicioContext>();
            builder.RegisterType<ExercicioTreinoContext>().As<IExercicioTreinoContext>();
            builder.RegisterType<FlexibilidadeContext>().As<IFlexibilidadeContext>();
            builder.RegisterType<ForcaResistenciaMuscularContext>().As<IForcaResistenciaMuscularContext>();
            builder.RegisterType<IMCContext>().As<IIMCContext>();
            builder.RegisterType<ModalidadeContext>().As<IModalidadeContext>();
            builder.RegisterType<PARQContext>().As<IPARQContext>();
            builder.RegisterType<PerimetriaContext>().As<IPerimetriaContext>();
            builder.RegisterType<PeriodoModalidadeContext>().As<IPeriodoModalidadeContext>();
            builder.RegisterType<QuestionarioAhaContext>().As<IQuestionarioAhaContext>();
            builder.RegisterType<RCQContext>().As<IRCQContext>();
            builder.RegisterType<RiscoCoronarianoContext>().As<IRiscoCoronarianoContext>();
            builder.RegisterType<TreinoContext>().As<ITreinoContext>();
            #endregion
        }
    }
}
