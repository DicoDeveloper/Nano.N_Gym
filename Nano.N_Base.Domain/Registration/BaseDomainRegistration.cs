using Autofac;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Domain.Service.Sistema;
using Nano.N_Base.Domain.Service.Estoque;
using Nano.N_Base.Domain.Service.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;

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
            builder.RegisterType<EstoqueMensalService>().As<IEstoqueMensalService>();
            builder.RegisterType<EstoqueProdutoService>().As<IEstoqueProdutoService>();
            builder.RegisterType<FornecedorService>().As<IFornecedorService>();
            builder.RegisterType<FuncionarioService>().As<IFuncionarioService>();
            builder.RegisterType<InventarioService>().As<IInventarioService>();
            builder.RegisterType<ItemInventarioService>().As<IItemInventarioService>();
            builder.RegisterType<LimitadorEstoqueService>().As<ILimitadorEstoqueService>();
            builder.RegisterType<LoteCorService>().As<ILoteCorService>();
            builder.RegisterType<LoteCorTamanhoService>().As<ILoteCorTamanhoService>();
            builder.RegisterType<LoteTamanhoService>().As<ILoteTamanhoService>();
            builder.RegisterType<MovimentacaoEstoqueService>().As<IMovimentacaoEstoqueService>();
            builder.RegisterType<ParametroService>().As<IParametroService>();
            builder.RegisterType<ParametroEmpresaService>().As<IParametroEmpresaService>();
            builder.RegisterType<PermissaoUsuarioService>().As<IPermissaoUsuarioService>();
            builder.RegisterType<PessoaService>().As<IPessoaService>();
            builder.RegisterType<ProdutoService>().As<IProdutoService>();
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            #endregion
        }
    }
}
