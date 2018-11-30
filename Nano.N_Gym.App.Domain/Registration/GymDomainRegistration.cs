using Autofac;
using Nano.N_Base.Model.Interface;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Domain.Service;
using Nano.N_Gym.App.Domain.Service.Avaliacao;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nano.N_Gym.App.Domain.Registration
{
    public class GymDomainRegistration
    {
        public void Register(ref ContainerBuilder builder, AutofacInstanceContextMode autofacInstanceContextMode)
        {
            List<Type> tiposRepositorios = typeof(GymDomainRegistration).Assembly.GetTypes().Where(p => p.IsSubclassOf(typeof(GymBaseService<>)) && !p.IsAbstract).ToList();

            switch (autofacInstanceContextMode)
            {
                case AutofacInstanceContextMode.PerCall:
                    tiposRepositorios.ForEach(p => builder.RegisterType(p).AsImplementedInterfaces());
                    break;
                case AutofacInstanceContextMode.PerHttpRequest:
                    tiposRepositorios.ForEach(p => builder.RegisterType(p).AsImplementedInterfaces().InstancePerRequest());
                    break;
                case AutofacInstanceContextMode.PerLifetimeScope:
                    tiposRepositorios.ForEach(p => builder.RegisterType(p).AsImplementedInterfaces().InstancePerLifetimeScope());
                    break;
            }

            #region Services
            builder.RegisterType<AgendamentoService>().As<IAgendamentoService>();
            builder.RegisterType<AnamneseService>().As<IAnamneseService>();
            builder.RegisterType<AparelhoService>().As<IAparelhoService>();
            builder.RegisterType<CapacidadeAerobicaEstimadaService>().As<ICapacidadeAerobicaEstimadaService>();
            builder.RegisterType<CapacidadeAerobicaRealizadaService>().As<ICapacidadeAerobicaRealizadaService>();
            builder.RegisterType<CargoService>().As<ICargoService>();
            builder.RegisterType<ClienteService>().As<IClienteService>();
            builder.RegisterType<ColaboradorService>().As<IColaboradorService>();
            builder.RegisterType<ComposicaoCorporalService>().As<IComposicaoCorporalService>();
            builder.RegisterType<ContratoService>().As<IContratoService>();
            builder.RegisterType<DobrasCutaneasService>().As<IDobrasCutaneasService>();
            builder.RegisterType<ExercicioService>().As<IExercicioService>();
            builder.RegisterType<ExercicioTreinoService>().As<IExercicioTreinoService>();
            builder.RegisterType<FlexibilidadeService>().As<IFlexibilidadeService>();
            builder.RegisterType<ForcaResistenciaMuscularService>().As<IForcaResistenciaMuscularService>();
            builder.RegisterType<ImagemService>().As<IImagemService>();
            builder.RegisterType<IMCService>().As<IIMCService>();
            builder.RegisterType<LocalizacaoService>().As<ILocalizacaoService>();
            builder.RegisterType<MassaMuscularService>().As<IMassaMuscularService>();
            builder.RegisterType<ModalidadeService>().As<IModalidadeService>();
            builder.RegisterType<PARQService>().As<IPARQService>();
            builder.RegisterType<PerimetriaService>().As<IPerimetriaService>();
            builder.RegisterType<PeriodoTurmaService>().As<IPeriodoTurmaService>();
            builder.RegisterType<ProficaoService>().As<IProficaoService>();
            builder.RegisterType<QuestionarioAhaService>().As<IQuestionarioAhaService>();
            builder.RegisterType<RCQService>().As<IRCQService>();
            builder.RegisterType<RiscoCoronarianoService>().As<IRiscoCoronarianoService>();
            builder.RegisterType<TreinoService>().As<ITreinoService>();
            builder.RegisterType<TurmaService>().As<ITurmaService>();
            #endregion
        }
    }
}
