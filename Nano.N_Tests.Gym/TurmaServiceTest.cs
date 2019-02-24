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
    public class TurmaServiceTest
    {
        private readonly IoC _ioC;
        private readonly ITurmaService _turmaService;
        private readonly GymCommonTests _commonTests;

        public TurmaServiceTest()
        {
            _ioC = new IoC();
            _commonTests = new GymCommonTests(ioC: _ioC);

            _turmaService = _ioC.Resolve<ITurmaService>();
        }

        [TestMethod, ExpectedException(typeof(NullEntityException), "Serviço não trata entidade nula")]
        public void SalvarEntidadeNula()
        {
            _turmaService.Save(null);
        }

        [TestMethod, ExpectedException(typeof(NullEntityException), "Serviço não trata obrigatoriedade de empresa")]
        public void SalvarEntidadeSemEmpresa()
        {
            _turmaService.Save(new Turma
            {
                Nome = "Nome teste 1",
                Empresa = null
            });
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeDescricaoNula()
        {
            _turmaService.Save(new Turma
            {
                Nome = null,
                Empresa = _commonTests.DefinirEmpresa("1")
            });
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeDescricaoVasia()
        {
            _turmaService.Save(new Turma
            {
                Nome = string.Empty,
                Empresa = _commonTests.DefinirEmpresa("1")
            });
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeSemModalidade()
        {
            _turmaService.Save(new Turma
            {
                Nome = "Nome teste 4",
                Empresa = _commonTests.DefinirEmpresa("1"),
                Modalidade = null
            });
        }

        [TestMethod]
        public void Inserir()
        {
            _turmaService.Save(new Turma
            {
                Nome = "Nome teste 5",
                Empresa = _commonTests.DefinirEmpresa("1"),
                Modalidade = _commonTests.DefinirModalidade()
            });
        }

        [TestMethod, ExpectedException(typeof(DuplicatedPropertyException), "Serviço não trata propriedade com valores duplicados")]
        public void InserirProficaoComDescricaoDuplicado()
        {
            _turmaService.Save(new Turma
            {
                Nome = "Nome teste 6",
                Empresa = _commonTests.DefinirEmpresa("1"),
                Modalidade = _commonTests.DefinirModalidade()
            });

            _turmaService.Save(new Turma
            {
                Nome = "Nome teste 6",
                Empresa = _commonTests.DefinirEmpresa("1"),
                Modalidade = _commonTests.DefinirModalidade()
            });
        }

        [TestMethod]
        public void Inativar()
        {
            Turma turma = new Turma
            {
                Nome = "Nome teste 7",
                Empresa = _commonTests.DefinirEmpresa("1"),
                Modalidade = _commonTests.DefinirModalidade()
            };

            _turmaService.Save(turma);

            Assert.IsTrue(_turmaService.Inactivate(turma.Id));

            Assert.IsFalse(turma.Ativo);
        }

        [TestMethod]
        public void InserirComColaboradorECliente()
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
            using (ITurmaContext context = _ioC.Resolve<ITurmaContext>())
            {
                IQueryable<Turma> turmas = context.GetAll();

                if (turmas.Any())
                {
                    Assert.IsTrue(context.DeleteRange(turmas));
                }
            }
        }
    }
}
