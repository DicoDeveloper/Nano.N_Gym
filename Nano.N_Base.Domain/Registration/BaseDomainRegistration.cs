using Autofac;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Domain.Service.Sistema;
using Nano.N_Base.Domain.Service.Estoque;

namespace Nano.N_Base.Domain.Registration
{
    public static class BaseDomainRegistration
    {
        public static void Register(ref ContainerBuilder builder)
        {
            #region Services
            builder.RegisterType<AuditoriaService>().As<IAuditoriaService>();
            builder.RegisterType<CaracteristicaService>().As<ICaracteristicaService>();
            builder.RegisterType<CargoService>().As<ICargoService>();
            builder.RegisterType<EmpresaService>().As<IEmpresaService>();
            builder.RegisterType<EnderecoService>().As<IEnderecoService>();
            builder.RegisterType<EstoqueProdutoService>().As<IEstoqueProdutoService>();
            builder.RegisterType<FornecedorService>().As<IFornecedorService>();
            builder.RegisterType<FuncionarioService>().As<IFuncionarioService>();
            builder.RegisterType<ParametroService>().As<IParametroService>();
            builder.RegisterType<PermissaoUsuarioService>().As<IPermissaoUsuarioService>();
            builder.RegisterType<PessoaService>().As<IPessoaService>();
            builder.RegisterType<ProficaoService>().As<IProficaoService>();
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            #endregion
        }
    }
}
