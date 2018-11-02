using Autofac;
using Nano.N_Base.Data.Infra.Sistema;
using Nano.N_Base.Data.Infra.Estoque;
using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Data.Interface.Estoque;
using Nano.N_Base.Data.Repository.Sistema;
using Nano.N_Base.Data.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Data.Repository.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Data.Infra.ProdutoVinculos;
using Nano.N_Base.Data.Interface.ProdutoVinculos;
using Nano.N_Base.Data.Repository.Financeiro;
using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Data.Infra.Financeiro;
using Nano.N_Base.Data.Interface.Financeiro;

namespace Nano.N_Base.Data.Registration
{
    public static class BaseDataRegistration 
    {
        public static void Register(ref ContainerBuilder builder)
        {
            #region Repositories
            builder.RegisterType<AtributoProdutoRepository>().As<IAtributoProdutoRepository>();
            builder.RegisterType<AuditoriaRepository>().As<IAuditoriaRepository>();
            builder.RegisterType<CaracteristicaRepository>().As<ICaracteristicaRepository>();
            builder.RegisterType<CargoRepository>().As<ICargoRepository>();
            builder.RegisterType<CodigoProdutoRepository>().As<ICodigoProdutoRepository>();
            builder.RegisterType<ColaboradorRepository>().As<IColaboradorRepository>();
            builder.RegisterType<CondicaoPagamentoRepository>().As<ICondicaoPagamentoRepository>();
            builder.RegisterType<ContatoRepository>().As<IContatoRepository>();
            builder.RegisterType<DespesaReceitaRepository>().As<IDespesaReceitaRepository>();
            builder.RegisterType<DocumentoFinanceiroRepository>().As<IDocumentoFinanceiroRepository>();
            builder.RegisterType<EmpresaRepository>().As<IEmpresaRepository>();
            builder.RegisterType<EnderecoRepository>().As<IEnderecoRepository>();
            builder.RegisterType<EstoqueMensalRepository>().As<IEstoqueMensalRepository>();
            builder.RegisterType<EstoqueProdutoRepository>().As<IEstoqueProdutoRepository>();
            builder.RegisterType<FabricanteRepository>().As<IFabricanteRepository>();
            builder.RegisterType<FornecedorRepository>().As<IFornecedorRepository>();
            builder.RegisterType<InventarioRepository>().As<IInventarioRepository>();
            builder.RegisterType<ItemInventarioRepository>().As<IItemInventarioRepository>();
            builder.RegisterType<LimitadorEstoqueRepository>().As<ILimitadorEstoqueRepository>();
            builder.RegisterType<LoteCorRepository>().As<ILoteCorRepository>();
            builder.RegisterType<LoteCorTamanhoRepository>().As<ILoteCorTamanhoRepository>();
            builder.RegisterType<LoteTamanhoRepository>().As<ILoteTamanhoRepository>();
            builder.RegisterType<MeioPagamentoRepository>().As<IMeioPagamentoRepository>();
            builder.RegisterType<MovimentacaoEstoqueRepository>().As<IMovimentacaoEstoqueRepository>();
            builder.RegisterType<ParametroRepository>().As<IParametroRepository>();
            builder.RegisterType<ParametroEmpresaRepository>().As<IParametroEmpresaRepository>();
            builder.RegisterType<PermissaoUsuarioRepository>().As<IPermissaoUsuarioRepository>();
            builder.RegisterType<PessoaRepository>().As<IPessoaRepository>();
            builder.RegisterType<ProdutoRepository>().As<IProdutoRepository>();
            builder.RegisterType<TituloFinanceiroRepository>().As<ITituloFinanceiroRepository>();
            builder.RegisterType<TransacaoRepository>().As<ITransacaoRepository>();
            builder.RegisterType<TransportadoraRepository>().As<ITransportadoraRepository>();
            builder.RegisterType<UnidadeMedidaRepository>().As<IUnidadeMedidaRepository>();            
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();            
            #endregion

            #region Contexties
            builder.RegisterType<AtributoProdutoContext>().As<IAtributoProdutoContext>();
            builder.RegisterType<AuditoriaContext>().As<IAuditoriaContext>();
            builder.RegisterType<CaracteristicaContext>().As<ICaracteristicaContext>();
            builder.RegisterType<CargoContext>().As<ICargoContext>();
            builder.RegisterType<CodigoProdutoContext>().As<ICodigoProdutoContext>();
            builder.RegisterType<ColaboradorContext>().As<IColaboradorContext>();
            builder.RegisterType<CondicaoPagamentoContext>().As<ICondicaoPagamentoContext>();
            builder.RegisterType<ContatoContext>().As<IContatoContext>();
            builder.RegisterType<DespesaReceitaContext>().As<IDespesaReceitaContext>();
            builder.RegisterType<DocumentoFinanceiroContext>().As<IDocumentoFinanceiroContext>();
            builder.RegisterType<EmpresaContext>().As<IEmpresaContext>();
            builder.RegisterType<EnderecoContext>().As<IEnderecoContext>();
            builder.RegisterType<EstoqueMensalContext>().As<IEstoqueMensalContext>();
            builder.RegisterType<EstoqueProdutoContext>().As<IEstoqueProdutoContext>();
            builder.RegisterType<FabricanteContext>().As<IFabricanteContext>();
            builder.RegisterType<FornecedorContext>().As<IFornecedorContext>();
            builder.RegisterType<InventarioContext>().As<IInventarioContext>();
            builder.RegisterType<ItemInventarioContext>().As<IItemInventarioContext>();
            builder.RegisterType<LimitadorEstoqueContext>().As<ILimitadorEstoqueContext>();
            builder.RegisterType<LoteCorContext>().As<ILoteCorContext>();
            builder.RegisterType<LoteCorTamanhoContext>().As<ILoteCorTamanhoContext>();
            builder.RegisterType<LoteTamanhoContext>().As<ILoteTamanhoContext>();
            builder.RegisterType<MeioPagamentoContext>().As<IMeioPagamentoContext>();
            builder.RegisterType<MovimentacaoEstoqueContext>().As<IMovimentacaoEstoqueContext>();
            builder.RegisterType<ParametroContext>().As<IParametroContext>();
            builder.RegisterType<ParametroEmpresaContext>().As<IParametroEmpresaContext>();
            builder.RegisterType<PermissaoUsuarioContext>().As<IPermissaoUsuarioContext>();
            builder.RegisterType<PessoaContext>().As<IPessoaContext>();
            builder.RegisterType<ProdutoContext>().As<IProdutoContext>();
            builder.RegisterType<TituloFinanceiroContext>().As<ITituloFinanceiroContext>();
            builder.RegisterType<TransacaoContext>().As<ITransacaoContext>();
            builder.RegisterType<TransportadoraContext>().As<ITransportadoraContext>();
            builder.RegisterType<UnidadeMedidaContext>().As<IUnidadeMedidaContext>();            
            builder.RegisterType<UsuarioContext>().As<IUsuarioContext>();            
            #endregion
        }
    }
}
