using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nano.N_Base.Model.Exception;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;
using Nano.N_IoC;
using System;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Nano.N_Gym.App.Tests.Domain
{
    [TestClass]
    public class CargoServiceTest
    {
        private readonly IoC _ioC;
        private readonly ICargoService _cargoService;
        private readonly GymCommonTests _commonTests;

        public CargoServiceTest()
        {
            _ioC = new IoC();
            _commonTests = new GymCommonTests(ioC: _ioC);

            _cargoService = _ioC.Resolve<ICargoService>();
        }

        [TestMethod, ExpectedException(typeof(NullEntityException), "Serviço não trata entidade nula")]
        public void SalvarEntidadeNula()
        {
            _cargoService.Save(null);
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeDescricaoNula()
        {
            _cargoService.Save(new Cargo
            {
                Descricao = null
            });
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeDescricaoVasia()
        {
            _cargoService.Save(new Cargo
            {
                Descricao = string.Empty
            });
        }

        [TestMethod]
        public void Inserir()
        {
            _cargoService.Save(new Cargo
            {
                Descricao = "Descricao teste 4"
            });
        }

        [TestMethod, ExpectedException(typeof(DuplicatedPropertyException), "Serviço não trata propriedade com valores duplicados")]
        public void InserirCargoComDescricaoDuplicado()
        {
            _cargoService.Save(new Cargo
            {
                Descricao = "Descricao teste 5"
            });

            _cargoService.Save(new Cargo
            {
                Descricao = "Descricao teste 5"
            });
        }

        [TestMethod]
        public void Inativar()
        {
            Cargo cargo = new Cargo
            {
                Descricao = "Descricao teste 6"
            };

            _cargoService.Save(cargo);

            Assert.IsTrue(_cargoService.Inactivate(cargo.Id));

            Assert.IsFalse(cargo.Ativo);
        }

        [TestMethod]
        public void InserirComFuncionario()
        {
            throw new NotImplementedException();
        }

        [TestMethod, ExpectedException(typeof(DbUpdateException), "Serviço não trata exclusão em cascata")]
        public void ExcluirComVinculo()
        {
            throw new NotImplementedException();
        }

        [TestCleanup()]
        public void CleanupAfterAllTests()
        {
            using (ICargoContext context = _ioC.Resolve<ICargoContext>())
            {
                IQueryable<Cargo> cargos = context.GetAll();

                if (cargos.Any())
                {
                    Assert.IsTrue(context.DeleteRange(cargos));
                }
            }
        }
    }
}
