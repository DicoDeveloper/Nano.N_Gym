using Microsoft.Extensions.DependencyInjection;
using N_Base.Data.Infra;
using N_Gym.Data.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Diagnostics;
using AutoMapper;
using N_Base.Data.Interfaces;
using N_Base.Domain.Interfaces.Repositories;
using N_Base.Data.Repository;
using N_Base.Domain.Interfaces.Services;
using N_Base.Domain.Services;
using N_Gym.Data.Interfaces;
using N_Gym.Domain.Interfaces.Repositories;
using N_Gym.Data.Repository;
using N_Gym.Domain.Interfaces.Services;
using N_Gym.Domain.Services;
using N_Gym.Application.Interfaces;
using N_Gym.Application.Services;
using N_Base.Entity.Objects;

namespace N_Gym.CrossCutting.IoC
{
    public class Injector
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextGym>(options =>
               options.UseSqlServer(configuration.GetConnectionString("N_Gym_DataBase"),
               b => b.MigrationsAssembly("N_Gym_API"))
               .ConfigureWarnings(warnings => warnings.Throw(CoreEventId.IncludeIgnoredWarning)));
            services.AddDbContext<ContextBase>(options =>
               options.UseSqlServer(configuration.GetConnectionString("N_Gym_DataBase"),
               b => b.MigrationsAssembly("N_Gym_API"))
               .ConfigureWarnings(warnings => warnings.Throw(CoreEventId.IncludeIgnoredWarning)));

            // Context
            services.AddTransient<IContext, ContextGym>();
            services.AddTransient<IContextGym, ContextGym>();

            // Base - Domain - Interfaces - Repository
            services.AddTransient<IAuditoriaRepository, AuditoriaRepository>();
            services.AddTransient<ICargoRepository, CargoRepository>();
            services.AddTransient<IContaRepository, ContaRepository>();
            services.AddTransient<IEnderecoRepository, EnderecoRepository>();
            services.AddTransient<IFuncionarioRepository, FuncionarioRepository>();
            services.AddTransient<ILojaRepository, LojaRepository>();
            services.AddTransient<IPagamentoRepository, PagamentoRepository>();
            services.AddTransient<IPermissaoUsuarioRepository, PermissaoUsuarioRepository>();
            services.AddTransient<ISystemConfigRepository, SystemConfigRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            // Base - Domain - Services
            services.AddTransient<IRepositoryBase<Auditoria>, AuditoriaRepository>();
            // Base - Domain - Interfaces - Services
            services.AddTransient<IAuditoriaService, AuditoriaService>();
            services.AddTransient<ICargoService, CargoService>();
            services.AddTransient<IContaService, ContaService>();
            services.AddTransient<IEnderecoService, EnderecoService>();
            services.AddTransient<IFuncionarioService, FuncionarioService>();
            services.AddTransient<ILojaService, LojaService>();
            services.AddTransient<IPagamentoService, PagamentoService>();
            services.AddTransient<IPermissaoUsuarioService, PermissaoUsuarioService>();
            services.AddTransient<ISystemConfigService, SystemConfigService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            // Gym - Domain - Interfaces - Repository
            services.AddTransient<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IContratoRepository, ContratoRepository>();
            services.AddTransient<IConvenioRepository, ConvenioRepository>();
            services.AddTransient<IEquipamentoAparelhoRepository, EquipamentoAparelhoRepository>();
            services.AddTransient<IExercicioRepository, ExercicioRepository>();
            services.AddTransient<IFichaAvaliacaoClienteRepository, FichaAvaliacaoClienteRepository>();
            services.AddTransient<IModalidadeRepository, ModalidadeRepository>();
            services.AddTransient<IPeriodoModalidadeRepository, PeriodoModalidadeRepository>();
            services.AddTransient<ITreinoRepository, TreinoRepository>();
            // Gym - Domain - Interfaces - Services
            services.AddTransient<IAvaliacaoService, AvaliacaoService>();
            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IContratoService, ContratoService>();
            services.AddTransient<IConvenioService, ConvenioService>();
            services.AddTransient<IEquipamentoAparelhoService, EquipamentoAparelhoService>();
            services.AddTransient<IExercicioService, ExercicioService>();
            services.AddTransient<IFichaAvaliacaoClienteService, FichaAvaliacaoClienteService>();
            services.AddTransient<IModalidadeService, ModalidadeService>();
            services.AddTransient<IPeriodoModalidadeService, PeriodoModalidadeService>();
            services.AddTransient<ITreinoService, TreinoService>();
            // Gym - Application - Interfaces
            services.AddTransient<IAuditoriaServiceApp, AuditoriaServiceApp>();
            services.AddTransient<IAvaliacaoServiceApp, AvaliacaoServiceApp>();
            services.AddTransient<ICargoServiceApp, CargoServiceApp>();
            services.AddTransient<IClienteServiceApp, ClienteServiceApp>();
            services.AddTransient<IContaServiceApp, ContaServiceApp>();
            services.AddTransient<IContratoServiceApp, ContratoServiceApp>();
            services.AddTransient<IConvenioServiceApp, ConvenioServiceApp>();
            services.AddTransient<IEnderecoServiceApp, EnderecoServiceApp>();
            services.AddTransient<IEquipamentoAparelhoServiceApp, EquipamentoAparelhoServiceApp>();
            services.AddTransient<IExercicioServiceApp, ExercicioServiceApp>();
            services.AddTransient<IFichaAvaliacaoClienteServiceApp, FichaAvaliacaoClienteServiceApp>();
            services.AddTransient<IFuncionarioServiceApp, FuncionarioServiceApp>();
            services.AddTransient<ILojaServiceApp, LojaServiceApp>();
            services.AddTransient<IModalidadeServiceApp, ModalidadeServiceApp>();
            services.AddTransient<IPagamentoServiceApp, PagamentoServiceApp>();
            services.AddTransient<IPeriodoModalidadeServiceApp, PeriodoModalidadeServiceApp>();
            services.AddTransient<IPermissaoUsuarioServiceApp, PermissaoUsuarioServiceApp>();
            services.AddTransient<ISystemConfigServiceApp, SystemConfigServiceApp>();
            services.AddTransient<ITreinoServiceApp, TreinoServiceApp>();
            services.AddTransient<IUsuarioServiceApp, UsuarioServiceApp>();
            // Gym - Application - Services
            services.AddTransient<IServiceBase<Auditoria>, ServiceBase<Auditoria>>();
        }
    }
}