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
            builder.RegisterType<AvaliacaoRepository>().As<IAvaliacaoRepository>();
            builder.RegisterType<ClienteRepository>().As<IClienteRepository>();
            builder.RegisterType<ContratoRepository>().As<IContratoRepository>();
            builder.RegisterType<ExercicioRepository>().As<IExercicioRepository>();
            builder.RegisterType<ExercicioTreinoRepository>().As<IExercicioTreinoRepository>();
            builder.RegisterType<FichaAvaliacaoRepository>().As<IFichaAvaliacaoRepository>();
            builder.RegisterType<ModalidadeRepository>().As<IModalidadeRepository>();
            builder.RegisterType<PeriodoModalidadeRepository>().As<IPeriodoModalidadeRepository>();
            builder.RegisterType<ProficaoRepository>().As<IProficaoRepository>();
            builder.RegisterType<TreinoRepository>().As<ITreinoRepository>();
            #endregion

            #region Contexties
            builder.RegisterType<AparelhoContext>().As<IAparelhoContext>();
            builder.RegisterType<AvaliacaoContext>().As<IAvaliacaoContext>();
            builder.RegisterType<ClienteContext>().As<IClienteContext>();
            builder.RegisterType<ContratoContext>().As<IContratoContext>();
            builder.RegisterType<ExercicioContext>().As<IExercicioContext>();
            builder.RegisterType<ExercicioTreinoContext>().As<IExercicioTreinoContext>();
            builder.RegisterType<FichaAvaliacaoContext>().As<IFichaAvaliacaoContext>();
            builder.RegisterType<ModalidadeContext>().As<IModalidadeContext>();
            builder.RegisterType<PeriodoModalidadeContext>().As<IPeriodoModalidadeContext>();
            builder.RegisterType<ProficaoContext>().As<IProficaoContext>();
            builder.RegisterType<TreinoContext>().As<ITreinoContext>();
            #endregion
        }
    }
}
