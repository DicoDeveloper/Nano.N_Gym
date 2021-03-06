﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nano.N_Base.Model.Exception;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;
using Nano.N_IoC;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Nano.N_Gym.App.Tests.Domain
{
    [TestClass]
    public class AparelhoServiceTest
    {
        private readonly IoC _ioC;
        private readonly IAparelhoService _aparelhoService;
        private readonly GymCommonTests _commonTests;

        public AparelhoServiceTest()
        {
            _ioC = new IoC();
            _commonTests = new GymCommonTests(ioC: _ioC);

            _aparelhoService = _ioC.Resolve<IAparelhoService>();
        }

        [TestMethod, ExpectedException(typeof(NullEntityException), "Serviço não trata entidade nula")]
        public void SalvarEntidadeNula()
        {
            _aparelhoService.Save(null);
        }

        [TestMethod, ExpectedException(typeof(NullEntityException), "Serviço não trata obrigatoriedade de empresa")]
        public void SalvarEntidadeSemEmpresa()
        {
            _aparelhoService.Save(new Aparelho
            {
                Nome = "Aparelho teste 1",
                Descricao = "Descricao teste 1",
            });
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeNomeNula()
        {
            _aparelhoService.Save(new Aparelho
            {
                Nome = null,
                Descricao = "Descricao teste 2",
                Empresa = _commonTests.DefinirEmpresa("1")
            });
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeNomeVasia()
        {
            _aparelhoService.Save(new Aparelho
            {
                Nome = string.Empty,
                Descricao = "Descricao teste 3",
                Empresa = _commonTests.DefinirEmpresa("1")
            });
        }

        [TestMethod]
        public void Inserir()
        {
            _aparelhoService.Save(new Aparelho
            {
                Nome = "Aparelho teste 4",
                Descricao = "Descricao teste 4",
                DataAquisicao = DateTime.Now.Date,
                Numeracao = "001",
                ValorAquisicao = 5395.50m,
                Empresa = _commonTests.DefinirEmpresa("1")
            });
        }

        [TestMethod, ExpectedException(typeof(DuplicatedPropertyException), "Serviço não trata propriedade com valores duplicados")]
        public void InserirAparelhoComNomeENumeracaoDuplicado()
        {
            _aparelhoService.Save(new Aparelho
            {
                Nome = "Aparelho teste 5",
                Descricao = "Descricao teste 5",
                DataAquisicao = DateTime.Now.Date,
                Numeracao = "001",
                ValorAquisicao = 5395.50m,
                Empresa = _commonTests.DefinirEmpresa("1")
            });

            _aparelhoService.Save(new Aparelho
            {
                Nome = "Aparelho teste 5",
                Descricao = "Descricao teste 5",
                DataAquisicao = DateTime.Now.Date,
                Numeracao = "001",
                ValorAquisicao = 5395.50m,
                Empresa = _commonTests.DefinirEmpresa("1")
            });
        }

        [TestMethod]
        public void Inativar()
        {
            Aparelho aparelho = new Aparelho
            {
                Nome = "Aparelho teste 7",
                Descricao = "Descricao teste 7",
                DataAquisicao = DateTime.Now.Date,
                Numeracao = "001",
                ValorAquisicao = 5395.50m,
                Empresa = _commonTests.DefinirEmpresa("1")
            };

            _aparelhoService.Save(aparelho);

            Assert.IsTrue(_aparelhoService.Inactivate(aparelho.Id));

            Assert.IsFalse(aparelho.Ativo);
        }

        [TestMethod]
        public void InserirComLocalizacao()
        {
            _aparelhoService.Save(new Aparelho
            {
                Nome = "Aparelho teste 8",
                Descricao = "Descricao teste 8",
                DataAquisicao = DateTime.Now.Date,
                Numeracao = "001",
                ValorAquisicao = 5395.50m,
                Empresa = _commonTests.DefinirEmpresa("1"),
                Localizacao = _commonTests.DefinirLocalizacao()
            });
        }

        [TestMethod, ExpectedException(typeof(DbUpdateException), "Serviço não trata exclusão em cascata")]
        public void ExcluirComVinculo()
        {
            Aparelho aparelho = new Aparelho
            {
                Nome = "Aparelho teste 9",
                Descricao = "Descricao teste 9",
                DataAquisicao = DateTime.Now.Date,
                Numeracao = "001",
                ValorAquisicao = 5395.50m,
                Empresa = _commonTests.DefinirEmpresa("1"),
                Imagens = new List<Imagem> { _commonTests.DefinirImagem() }
            };

            _aparelhoService.Save(aparelho);

            _aparelhoService.Delete(aparelho);
        }

        [TestCleanup()]
        public void CleanupAfterAllTests()
        {
            using (IAparelhoContext context = _ioC.Resolve<IAparelhoContext>())
            {
                IQueryable<Aparelho> aparelhos = context.GetAll();

                if (aparelhos.Any())
                {
                    Assert.IsTrue(context.DeleteRange(aparelhos));
                }
            }
        }
    }
}
