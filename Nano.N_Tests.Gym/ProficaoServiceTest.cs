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
    public class ProficaoServiceTest
    {
        private readonly IoC _ioC;
        private readonly IProficaoService _proficaoService;
        private readonly GymCommonTests _commonTests;

        public ProficaoServiceTest()
        {
            _ioC = new IoC();
            _commonTests = new GymCommonTests(ioC: _ioC);

            _proficaoService = _ioC.Resolve<IProficaoService>();
        }

        [TestMethod, ExpectedException(typeof(NullEntityException), "Serviço não trata entidade nula")]
        public void SalvarEntidadeNula()
        {
            _proficaoService.Save(null);
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeDescricaoNula()
        {
            _proficaoService.Save(new Proficao
            {
                Descricao = null
            });
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeDescricaoVasia()
        {
            _proficaoService.Save(new Proficao
            {
                Descricao = string.Empty
            });
        }

        [TestMethod]
        public void Inserir()
        {
            _proficaoService.Save(new Proficao
            {
                Descricao = "Descricao teste 4"
            });
        }

        [TestMethod, ExpectedException(typeof(DuplicatedPropertyException), "Serviço não trata propriedade com valores duplicados")]
        public void InserirProficaoComDescricaoDuplicado()
        {
            _proficaoService.Save(new Proficao
            {
                Descricao = "Descricao teste 5"
            });

            _proficaoService.Save(new Proficao
            {
                Descricao = "Descricao teste 5"
            });
        }

        [TestMethod]
        public void Inativar()
        {
            Proficao proficao = new Proficao
            {
                Descricao = "Descricao teste 6"
            };

            _proficaoService.Save(proficao);

            Assert.IsTrue(_proficaoService.Inactivate(proficao.Id));

            Assert.IsFalse(proficao.Ativo);
        }

        [TestMethod]
        public void InserirComCliente()
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
            using (IProficaoContext context = _ioC.Resolve<IProficaoContext>())
            {
                IQueryable<Proficao> proficoes = context.GetAll();

                if (proficoes.Any())
                {
                    Assert.IsTrue(context.DeleteRange(proficoes));
                }
            }
        }
    }
}
