using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nano.N_Base.Model.Exception;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;
using Nano.N_IoC;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Nano.N_Gym.App.Tests.Domain
{
    [TestClass]
    public class LocalizacaoServiceTest
    {
        private readonly ILocalizacaoService _localizacaoService;
        private readonly GymCommonTests _commonTests;

        public LocalizacaoServiceTest()
        {
            IoC _ioC = new IoC();
            _commonTests = new GymCommonTests(_ioC);

            _localizacaoService = _ioC.Resolve<ILocalizacaoService>();
        }

        [TestMethod, ExpectedException(typeof(NullEntityException), "Serviço não trata entidade nula")]
        public void SalvarEntidadeNula()
        {
            _localizacaoService.Save(null);
        }

        [TestMethod, ExpectedException(typeof(NullEntityException), "Serviço não trata obrigatoriedade de empresa")]
        public void SalvarEntidadeSemEmpresa()
        {
            _localizacaoService.Save(new Localizacao
            {
                Descricao = "Localizacao teste 1",
                Observacoes = "Observacao teste 1",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m
            });
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeDescricaoNula()
        {
            _localizacaoService.Save(new Localizacao
            {
                Descricao = null,
                Observacoes = "Observacao teste 1",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m,
                Empresa = _commonTests.DefinirEmpresa("1")
            });
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeDescricaoVasia()
        {
            _localizacaoService.Save(new Localizacao
            {
                Descricao = string.Empty,
                Observacoes = "Observacao teste 1",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m,
                Empresa = _commonTests.DefinirEmpresa("1")
            });
        }

        [TestMethod]
        public void Inserir()
        {
            _localizacaoService.Save(new Localizacao
            {
                Descricao = "Localizacao teste 2",
                Observacoes = "Observacao teste 2",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m,
                Empresa = _commonTests.DefinirEmpresa("1")
            });
        }

        [TestMethod, ExpectedException(typeof(DuplicatedPropertyException), "Serviço não trata propriedade com valores duplicados")]
        public void InserirLocalizacaoComDescricaoDuplicado()
        {
            _localizacaoService.Save(new Localizacao
            {
                Descricao = "Localizacao teste 3",
                Observacoes = "Observacao teste 3",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m,
                Empresa = _commonTests.DefinirEmpresa("1")
            });

            _localizacaoService.Save(new Localizacao
            {
                Descricao = "Localizacao teste 3",
                Observacoes = "Observacao teste 3",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m,
                Empresa = _commonTests.DefinirEmpresa("1")
            });
        }

        [TestMethod]
        public void Inativar()
        {
            Localizacao localizacao = new Localizacao
            {
                Descricao = "Localizacao teste 4",
                Observacoes = "Observacao teste 4",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m,
                Empresa = _commonTests.DefinirEmpresa("1")
            };

            _localizacaoService.Save(localizacao);

            Assert.IsTrue(_localizacaoService.Inactivate(localizacao.Id));

            Assert.IsFalse(localizacao.Ativo);
        }

        [TestMethod, ExpectedException(typeof(InvalidHierarchyException), "Serviço não trata hierarquia invalida")]
        public void InserirComoProprioPai()
        {
            Localizacao localizacao = new Localizacao
            {
                Descricao = "Localizacao teste 5",
                Observacoes = "Observacao teste 5",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m,
                Empresa = _commonTests.DefinirEmpresa("1")
            };

            _localizacaoService.Save(localizacao);

            localizacao.Pai = localizacao;

            _localizacaoService.Save(localizacao);
        }

        [TestMethod, ExpectedException(typeof(DbUpdateException), "Serviço não trata exclusão em cascata")]
        public void ExcluirComVinculo()
        {
            Localizacao localizacao = new Localizacao
            {
                Descricao = "Localizacao teste 6",
                Observacoes = "Observacao teste 6",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m,
                Empresa = _commonTests.DefinirEmpresa("1")
            };

            _localizacaoService.Save(localizacao);

            _commonTests.DefinirAparelhoComLocalizacao(localizacao);

            _localizacaoService.Delete(localizacao);
        }

        [TestMethod, ExpectedException(typeof(InvalidDeleteOperationException), "Serviço não trata exclusão com vinculo")]
        public void ExcluirComFilho()
        {
            Localizacao localizacao = new Localizacao
            {
                Descricao = "Localizacao teste 7",
                Observacoes = "Observacao teste 7",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m,
                Empresa = _commonTests.DefinirEmpresa("1")
            };

            _localizacaoService.Save(localizacao);

            Localizacao filho = new Localizacao
            {
                Descricao = "Localizacao teste 8",
                Observacoes = "Observacao teste 8",
                Altura = 10m,
                Largura = null,
                Comprimento = 15m,
                Empresa = _commonTests.DefinirEmpresa("1"),
                Pai = localizacao
            };

            _localizacaoService.Save(filho);

            _localizacaoService.Delete(localizacao);
        }

        [TestCleanup()]
        public void CleanupAfterAllTests()
        {
            using (ILocalizacaoContext context = new IoC().Resolve<ILocalizacaoContext>())
            {
                IQueryable<Localizacao> localizacoes = context.GetAll();

                if (localizacoes.Any())
                {
                    using (IAparelhoContext aparelhoContext = new IoC().Resolve<IAparelhoContext>())
                    {
                        IQueryable<Aparelho> aparelhos = aparelhoContext.GetAll().Where(a => a.Localizacao != null);
                        if (aparelhos.Count() > 0)
                            aparelhoContext.DeleteRange(aparelhos);
                    }

                    Assert.IsTrue(context.DeleteRange(localizacoes));
                }
            }
        }
    }
}
