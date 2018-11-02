using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Tests.Commom;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;

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
            Assert.IsNotNull(_ioc);
        }

    }
}
