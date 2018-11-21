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
            builder.RegisterType<AgendamentoRepository>().As<IAgendamentoRepository>();
            builder.RegisterType<AnamneseRepository>().As<IAnamneseRepository>();
            builder.RegisterType<AparelhoRepository>().As<IAparelhoRepository>();
            builder.RegisterType<AvaliacaoBaseRepository>().As<IAvaliacaoBaseRepository>();
            builder.RegisterType<CapacidadeAerobicaEstimadaRepository>().As<ICapacidadeAerobicaEstimadaRepository>();
            builder.RegisterType<CapacidadeAerobicaRealizadaRepository>().As<ICapacidadeAerobicaRealizadaRepository>();
            builder.RegisterType<CargoRepository>().As<ICargoRepository>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<ColaboradorRepository>().As<IColaboradorRepository>();
            builder.RegisterType<ComposicaoCorporalRepository>().As<IComposicaoCorporalRepository>();
            builder.RegisterType<ContratoRepository>().As<IContratoRepository>();
            builder.RegisterType<DobrasCutaneasRepository>().As<IDobrasCutaneasRepository>();
            builder.RegisterType<ExercicioRepository>().As<IExercicioRepository>();
            builder.RegisterType<ExercicioTreinoRepository>().As<IExercicioTreinoRepository>();
            builder.RegisterType<FlexibilidadeRepository>().As<IFlexibilidadeRepository>();
            builder.RegisterType<ForcaResistenciaMuscularRepository>().As<IForcaResistenciaMuscularRepository>();
            builder.RegisterType<ImagemRepository>().As<IImagemRepository>();
            builder.RegisterType<IMCRepository>().As<IIMCRepository>();
            builder.RegisterType<LocalizacaoRepository>().As<ILocalizacaoRepository>();
            builder.RegisterType<MassaMuscularRepository>().As<IMassaMuscularRepository>();
            builder.RegisterType<ModalidadeRepository>().As<IModalidadeRepository>();
            builder.RegisterType<PARQRepository>().As<IPARQRepository>();
            builder.RegisterType<PerimetriaRepository>().As<IPerimetriaRepository>();
            builder.RegisterType<PeriodoTurmaRepository>().As<IPeriodoTurmaRepository>();
            builder.RegisterType<ProficaoRepository>().As<IProficaoRepository>();
            builder.RegisterType<QuestionarioAhaRepository>().As<IQuestionarioAhaRepository>();
            builder.RegisterType<RCQRepository>().As<IRCQRepository>();
            builder.RegisterType<RiscoCoronarianoRepository>().As<IRiscoCoronarianoRepository>();
            builder.RegisterType<TreinoRepository>().As<ITreinoRepository>();
            builder.RegisterType<TurmaRepository>().As<ITurmaRepository>();
            #endregion

            #region Contexties
            builder.RegisterType<AgendamentoContext>().As<IAgendamentoContext>();
            builder.RegisterType<AnamneseContext>().As<IAnamneseContext>();
            builder.RegisterType<AparelhoContext>().As<IAparelhoContext>();
            builder.RegisterType<AvaliacaoBaseContext>().As<IAvaliacaoBaseContext>();
            builder.RegisterType<CapacidadeAerobicaEstimadaContext>().As<ICapacidadeAerobicaEstimadaContext>();
            builder.RegisterType<CapacidadeAerobicaRealizadaContext>().As<ICapacidadeAerobicaRealizadaContext>();
            builder.RegisterType<CargoContext>().As<ICargoContext>();
            builder.RegisterType<ClienteContext>().As<IClienteContext>();
            builder.RegisterType<ColaboradorContext>().As<IColaboradorContext>();
            builder.RegisterType<ComposicaoCorporalContext>().As<IComposicaoCorporalContext>();
            builder.RegisterType<ContratoContext>().As<IContratoContext>();
            builder.RegisterType<DobrasCutaneasContext>().As<IDobrasCutaneasContext>();
            builder.RegisterType<ExercicioContext>().As<IExercicioContext>();
            builder.RegisterType<ExercicioTreinoContext>().As<IExercicioTreinoContext>();
            builder.RegisterType<FlexibilidadeContext>().As<IFlexibilidadeContext>();
            builder.RegisterType<ForcaResistenciaMuscularContext>().As<IForcaResistenciaMuscularContext>();
            builder.RegisterType<ImagemContext>().As<IImagemContext>();
            builder.RegisterType<IMCContext>().As<IIMCContext>();
            builder.RegisterType<LocalizacaoContext>().As<ILocalizacaoContext>();
            builder.RegisterType<MassaMuscularContext>().As<IMassaMuscularContext>();
            builder.RegisterType<ModalidadeContext>().As<IModalidadeContext>();
            builder.RegisterType<PARQContext>().As<IPARQContext>();
            builder.RegisterType<PerimetriaContext>().As<IPerimetriaContext>();
            builder.RegisterType<PeriodoTurmaContext>().As<IPeriodoTurmaContext>();
            builder.RegisterType<ProficaoContext>().As<IProficaoContext>();
            builder.RegisterType<QuestionarioAhaContext>().As<IQuestionarioAhaContext>();
            builder.RegisterType<RCQContext>().As<IRCQContext>();
            builder.RegisterType<RiscoCoronarianoContext>().As<IRiscoCoronarianoContext>();
            builder.RegisterType<TreinoContext>().As<ITreinoContext>();
            builder.RegisterType<TurmaContext>().As<ITurmaContext>();
            #endregion
        }
    }
}
