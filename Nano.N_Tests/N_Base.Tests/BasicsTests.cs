using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            IClienteService service = _ioc.Resolve<IClienteService>();
            Assert.IsNotNull(_ioc);
        }

    }
}
