using Autofac;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Domain.Service.Sistema;
using Nano.N_Base.Domain.Service.Estoque;
using Nano.N_Base.Domain.Service.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;
using Nano.N_Base.Domain.Service.Financeiro;
using Nano.N_Base.Domain.Interface.Service.Financeiro;
using Nano.N_Base.Domain.Service.Fiscal;
using Nano.N_Base.Domain.Interface.Service.Fiscal;

namespace Nano.N_Base.Domain.Registration
{
    public static class BaseDomainRegistration
    {
        public static void Register(ref ContainerBuilder builder)
        {
            #region Services
            builder.RegisterType<AgendamentoService>().As<IAgendamentoService>();
            builder.RegisterType<AtributoProdutoService>().As<IAtributoProdutoService>();
            builder.RegisterType<AuditoriaService>().As<IAuditoriaService>();
            builder.RegisterType<CaracteristicaService>().As<ICaracteristicaService>();
            builder.RegisterType<CargoService>().As<ICargoService>();
            builder.RegisterType<ClienteBaseService>().As<IClienteBaseService>();
            builder.RegisterType<CodigoProdutoService>().As<ICodigoProdutoService>();
            builder.RegisterType<CondicaoPagamentoService>().As<ICondicaoPagamentoService>();
            builder.RegisterType<ContatoService>().As<IContatoService>();
            builder.RegisterType<DespesaReceitaService>().As<IDespesaReceitaService>();
            builder.RegisterType<DocumentoFinanceiroService>().As<IDocumentoFinanceiroService>();
            builder.RegisterType<DocumentoFiscalService>().As<IDocumentoFiscalService>();
            builder.RegisterType<EmpresaService>().As<IEmpresaService>();
            builder.RegisterType<EnderecoService>().As<IEnderecoService>();
            builder.RegisterType<EstoqueMensalService>().As<IEstoqueMensalService>();
            builder.RegisterType<EstoqueProdutoService>().As<IEstoqueProdutoService>();
            builder.RegisterType<FabricanteService>().As<IFabricanteService>();
            builder.RegisterType<FornecedorService>().As<IFornecedorService>();
            builder.RegisterType<ColaboradorBaseService>().As<IColaboradorBaseService>();
            builder.RegisterType<InventarioService>().As<IInventarioService>();
            builder.RegisterType<ItemDocumentoFiscalService>().As<IItemDocumentoFiscalService>();
            builder.RegisterType<ItemInventarioService>().As<IItemInventarioService>();
            builder.RegisterType<LimitadorEstoqueService>().As<ILimitadorEstoqueService>();
            builder.RegisterType<LoteCorService>().As<ILoteCorService>();
            builder.RegisterType<LoteCorTamanhoService>().As<ILoteCorTamanhoService>();
            builder.RegisterType<LoteTamanhoService>().As<ILoteTamanhoService>();
            builder.RegisterType<MeioPagamentoService>().As<IMeioPagamentoService>();
            builder.RegisterType<ModeloFiscalService>().As<IModeloFiscalService>();
            builder.RegisterType<MovimentoEstoqueService>().As<IMovimentoEstoqueService>();
            builder.RegisterType<MovimentoFinanceiroService>().As<IMovimentoFinanceiroService>();
            builder.RegisterType<OperacaoFiscalService>().As<IOperacaoFiscalService>();
            builder.RegisterType<ParametroService>().As<IParametroService>();
            builder.RegisterType<ParametroEmpresaService>().As<IParametroEmpresaService>();
            builder.RegisterType<PermissaoUsuarioService>().As<IPermissaoUsuarioService>();
            builder.RegisterType<PessoaService>().As<IPessoaService>();
            builder.RegisterType<ProdutoService>().As<IProdutoService>();
            builder.RegisterType<ProficaoService>().As<IProficaoService>();
            builder.RegisterType<SerieFiscalService>().As<ISerieFiscalService>();
            builder.RegisterType<TituloFinanceiroService>().As<ITituloFinanceiroService>();
            builder.RegisterType<TransacaoService>().As<ITransacaoService>();
            builder.RegisterType<TransportadoraService>().As<ITransportadoraService>();
            builder.RegisterType<UnidadeMedidaService>().As<IUnidadeMedidaService>();
            builder.RegisterType<UsuarioService>().As<IUsuarioService>();
            #endregion
        }
    }
}
