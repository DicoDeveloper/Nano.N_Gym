using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Tests.Commom;

namespace Nano.N_Tests.N_Base.Tests
{
    [TestClass]
    public class BasicsTests
    {
        private readonly Ioc _ioc;

        public BasicsTests()
        {
            _ioc = new Ioc();
        }

        [TestMethod]
        public void TestCreateTablesDataBase()
        {
            _ioc.Resolve<IAparelhoService>();
            _ioc.Resolve<IAvaliacaoService>();
            _ioc.Resolve<ICaracteristicaService>();
            _ioc.Resolve<IClienteService>();
            _ioc.Resolve<IContratoService>();
            _ioc.Resolve<IEmpresaService>();
            _ioc.Resolve<IEnderecoService>();
            _ioc.Resolve<IEstoqueProdutoService>();
            _ioc.Resolve<IExercicioService>();
            _ioc.Resolve<IFichaAvaliacaoService>();
            _ioc.Resolve<IFornecedorService>();
            _ioc.Resolve<IModalidadeService>();
            _ioc.Resolve<IPeriodoModalidadeService>();
            _ioc.Resolve<IPermissaoUsuarioService>();
            _ioc.Resolve<IPessoaService>();
            _ioc.Resolve<ITreinoService>();
            _ioc.Resolve<IUsuarioService>();
        }

    }
}
