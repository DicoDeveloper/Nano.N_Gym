using Autofac;
using Nano.N_Base.Data.Infra;
using Nano.N_Base.Data.Interface;
using Nano.N_Base.Data.Repository;
using Nano.N_Base.Domain.Interface.Repository;

namespace Nano.N_Base.Data.Registration
{
    public static class BaseDataRegistration 
    {
        public static void Register(ref ContainerBuilder builder)
        {
            #region Repositories
            builder.RegisterType<CaracteristicaRepository>().As<ICaracteristicaRepository>();
            builder.RegisterType<EmpresaRepository>().As<IEmpresaRepository>();
            builder.RegisterType<EnderecoRepository>().As<IEnderecoRepository>();
            builder.RegisterType<EstoqueProdutoRepository>().As<IEstoqueProdutoRepository>();
            builder.RegisterType<FornecedorRepository>().As<IFornecedorRepository>();
            builder.RegisterType<PermissaoUsuarioRepository>().As<IPermissaoUsuarioRepository>();
            builder.RegisterType<PessoaRepository>().As<IPessoaRepository>();
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();
            #endregion

            #region Contexties
            builder.RegisterType<CaracteristicaContext>().As<ICaracteristicaContext>();
            builder.RegisterType<EmpresaContext>().As<IEmpresaContext>();
            builder.RegisterType<EnderecoContext>().As<IEnderecoContext>();
            builder.RegisterType<EstoqueProdutoContext>().As<IEstoqueProdutoContext>();
            builder.RegisterType<FornecedorContext>().As<IFornecedorContext>();
            builder.RegisterType<PermissaoUsuarioContext>().As<IPermissaoUsuarioContext>();
            builder.RegisterType<PessoaContext>().As<IPessoaContext>();
            builder.RegisterType<UsuarioContext>().As<IUsuarioContext>();
            #endregion
        }
    }
}
