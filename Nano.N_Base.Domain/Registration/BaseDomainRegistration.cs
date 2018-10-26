using Autofac;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Domain.Service;

namespace Nano.N_Base.Domain.Registration
{
    public static class BaseDomainRegistration
    {
        public static void Register(ref ContainerBuilder builder)
        {
            #region Services
            builder.RegisterType<CaracteristicaService>().As<ICaracteristicaService>();
            builder.RegisterType<EmpresaService>().As<IEmpresaService>();
            builder.RegisterType<EnderecoService>().As<IEnderecoService>();
            builder.RegisterType<EstoqueProdutoService>().As<IEstoqueProdutoService>();
            builder.RegisterType<FornecedorService>().As<IFornecedorService>();
            builder.RegisterType<PermissaoUsuarioService>().As<IPermissaoUsuarioService>();
            builder.RegisterType<PessoaService>().As<IPessoaService>();
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            #endregion
        }
    }
}
