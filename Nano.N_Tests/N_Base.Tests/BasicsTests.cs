using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_IoC;

namespace Nano.N_Tests.N_Base.Tests
{
    [TestClass]
    public class BasicsTests
    {
        private readonly IoC _ioc;

        public BasicsTests()
        {
            _ioc = new IoC();
        }

        [TestMethod]
        public void TestCreateTablesDataBase()
        {
            IClienteService service = _ioc.Resolve<IClienteService>();
            Assert.IsNotNull(_ioc);
        }

    }
}
