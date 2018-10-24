using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nano.N_Base.Data.Infra;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Model.Entity;
using System.Linq;

namespace Nano.N_Tests.N_Base.Tests
{
    [TestClass]
    public class BasicsTests
    {
        private readonly IEmpresaService _empresaService;

        //public BasicsTests(IEmpresaService empresaService)
        //{
        //    _empresaService = empresaService;
        //}

        [TestMethod]
        public void TestCreateDataBase()
        {
            var context = new EmpresaContext();
            IQueryable<Empresa> empresas = _empresaService.GetAll();
        }

    }
}
