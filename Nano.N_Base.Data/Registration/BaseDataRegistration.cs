using Autofac;
using Nano.N_Base.Data.Infra.Sistema;
using Nano.N_Base.Data.Infra.Estoque;
using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Data.Interface.Estoque;
using Nano.N_Base.Data.Repository.Sistema;
using Nano.N_Base.Data.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Estoque;

namespace Nano.N_Base.Data.Registration
{
    public static class BaseDataRegistration 
    {
        public static void Register(ref ContainerBuilder builder)
        {
            #region Repositories
            builder.RegisterType<AuditoriaRepository>().As<IAuditoriaRepository>();
            builder.RegisterType<CaracteristicaRepository>().As<ICaracteristicaRepository>();
            builder.RegisterType<CargoRepository>().As<ICargoRepository>();
            builder.RegisterType<EmpresaRepository>().As<IEmpresaRepository>();
            builder.RegisterType<EnderecoRepository>().As<IEnderecoRepository>();
            builder.RegisterType<EstoqueProdutoRepository>().As<IEstoqueProdutoRepository>();
            builder.RegisterType<FornecedorRepository>().As<IFornecedorRepository>();
            builder.RegisterType<FuncionarioRepository>().As<IFuncionarioRepository>();
            builder.RegisterType<ParametroRepository>().As<IParametroRepository>();
            builder.RegisterType<PermissaoUsuarioRepository>().As<IPermissaoUsuarioRepository>();
            builder.RegisterType<PessoaRepository>().As<IPessoaRepository>();
            builder.RegisterType<ProficaoRepository>().As<IProficaoRepository>();
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();            
            #endregion

            #region Contexties
            builder.RegisterType<AuditoriaContext>().As<IAuditoriaContext>();
            builder.RegisterType<CaracteristicaContext>().As<ICaracteristicaContext>();
            builder.RegisterType<CargoContext>().As<ICargoContext>();
            builder.RegisterType<EmpresaContext>().As<IEmpresaContext>();
            builder.RegisterType<EnderecoContext>().As<IEnderecoContext>();
            builder.RegisterType<EstoqueProdutoContext>().As<IEstoqueProdutoContext>();
            builder.RegisterType<FornecedorContext>().As<IFornecedorContext>();
            builder.RegisterType<FuncionarioContext>().As<IFuncionarioContext>();
            builder.RegisterType<ParametroContext>().As<IParametroContext>();
            builder.RegisterType<PermissaoUsuarioContext>().As<IPermissaoUsuarioContext>();
            builder.RegisterType<PessoaContext>().As<IPessoaContext>();
            builder.RegisterType<ProficaoContext>().As<IProficaoContext>();
            builder.RegisterType<UsuarioContext>().As<IUsuarioContext>();            
            #endregion
        }
    }
}
