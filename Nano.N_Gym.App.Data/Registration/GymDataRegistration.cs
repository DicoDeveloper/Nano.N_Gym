using Autofac;
using Nano.N_Gym.App.Data.Infra;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Data.Repository;
using Nano.N_Gym.App.Domain.Interface.Repository;

namespace Nano.N_Gym.App.Data.Registration
{
    public static class GymDataRegistration
    {
        public static void Register(ref ContainerBuilder builder)
        {
            #region Repositories
            builder.RegisterType<AparelhoRepository>().As<IAparelhoRepository>();
            builder.RegisterType<AvaliacaoAntropometricaRepository>().As<IAvaliacaoAntropometricaRepository>();
            builder.RegisterType<AvaliacaoBaseRepository>().As<IAvaliacaoBaseRepository>();
            builder.RegisterType<AvaliacaoCompletaRepository>().As<IAvaliacaoCompletaRepository>();
            builder.RegisterType<AvaliacaoComposicaoCorporalRepository>().As<IAvaliacaoComposicaoCorporalRepository>();
            builder.RegisterType<AvaliacaoIMCRepository>().As<IAvaliacaoIMCRepository>();
            builder.RegisterType<AvaliacaoPerimetriaRepository>().As<IAvaliacaoPerimetriaRepository>();
            builder.RegisterType<AvaliacaoRCQRepository>().As<IAvaliacaoRCQRepository>();
            builder.RegisterType<AvaliacaoRiscoCoronarianoRepository>().As<IAvaliacaoRiscoCoronarianoRepository>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<ColaboradorRepository>().As<IColaboradorRepository>();
            builder.RegisterType<ContratoRepository>().As<IContratoRepository>();
            builder.RegisterType<ExercicioRepository>().As<IExercicioRepository>();
            builder.RegisterType<ExercicioTreinoRepository>().As<IExercicioTreinoRepository>();
            builder.RegisterType<FichaAvaliacaoRepository>().As<IFichaAvaliacaoRepository>();
            builder.RegisterType<ModalidadeRepository>().As<IModalidadeRepository>();
            builder.RegisterType<PeriodoModalidadeRepository>().As<IPeriodoModalidadeRepository>();
            builder.RegisterType<TreinoRepository>().As<ITreinoRepository>();
            #endregion

            #region Contexties
            builder.RegisterType<AparelhoContext>().As<IAparelhoContext>();
            builder.RegisterType<AvaliacaoAntropometricaContext>().As<IAvaliacaoAntropometricaContext>();
            builder.RegisterType<AvaliacaoBaseContext>().As<IAvaliacaoBaseContext>();
            builder.RegisterType<AvaliacaoCompletaContext>().As<IAvaliacaoCompletaContext>();
            builder.RegisterType<AvaliacaoComposicaoCorporalContext>().As<IAvaliacaoComposicaoCorporalContext>();
            builder.RegisterType<AvaliacaoIMCContext>().As<IAvaliacaoIMCContext>();
            builder.RegisterType<AvaliacaoPerimetriaContext>().As<IAvaliacaoPerimetriaContext>();
            builder.RegisterType<AvaliacaoRCQContext>().As<IAvaliacaoRCQContext>();
            builder.RegisterType<AvaliacaoRiscoCoronarianoContext>().As<IAvaliacaoRiscoCoronarianoContext>();
            builder.RegisterType<ClienteContext>().As<IClienteContext>();
            builder.RegisterType<ColaboradorContext>().As<IColaboradorContext>();
            builder.RegisterType<ContratoContext>().As<IContratoContext>();
            builder.RegisterType<ExercicioContext>().As<IExercicioContext>();
            builder.RegisterType<ExercicioTreinoContext>().As<IExercicioTreinoContext>();
            builder.RegisterType<FichaAvaliacaoContext>().As<IFichaAvaliacaoContext>();
            builder.RegisterType<ModalidadeContext>().As<IModalidadeContext>();
            builder.RegisterType<PeriodoModalidadeContext>().As<IPeriodoModalidadeContext>();
            builder.RegisterType<TreinoContext>().As<ITreinoContext>();
            #endregion
        }
    }
}
