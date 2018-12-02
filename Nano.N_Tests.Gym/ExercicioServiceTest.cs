using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nano.N_Base.Model.Exception;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;
using Nano.N_IoC;
using System.Linq;

namespace Nano.N_Gym.App.Tests.Domain
{
    [TestClass]
    public class ExercicioServiceTest
    {
        private readonly IExercicioService _exercicioService;

        public ExercicioServiceTest()
        {
            IoC _ioc = new IoC();

            _exercicioService = _ioc.Resolve<IExercicioService>();
        }

        [TestMethod, ExpectedException(typeof(NullEntityException), "Serviço não trata entidade nula")]
        public void SalvarEntidadeNula()
        {
            _exercicioService.Save(null);
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeNomeNula()
        {
            _exercicioService.Save(new Exercicio { Nome = null });
        }

        [TestMethod, ExpectedException(typeof(InvalidOrNullRequiredPropertyException), "Serviço não trata propriedade obrigatória da entidade")]
        public void SalvarEntidadeComPropriedadeNomeVasia()
        {
            _exercicioService.Save(new Exercicio { Nome = string.Empty });
        }

        [TestMethod]
        public void Inserir()
        {
            _exercicioService.Save(new Exercicio
            {
                Nome = "Exercicio teste 1",
                Descricao = "Descricao teste 1",
                Tipo = Model.Enum.Exercicio.TipoExercicio.Abdominal
            });
        }

        [TestMethod, ExpectedException(typeof(DuplicatedPropertyException), "Serviço não trata propriedade com valores duplicados")]
        public void InserirExercicioComNomeDuplicado()
        {
            _exercicioService.Save(new Exercicio
            {
                Nome = "Exercicio teste 2",
                Descricao = "Descricao teste 2",
                Tipo = Model.Enum.Exercicio.TipoExercicio.Abdominal
            });

            _exercicioService.Save(new Exercicio
            {
                Nome = "Exercicio teste 2",
                Descricao = "Descricao teste 2",
                Tipo = Model.Enum.Exercicio.TipoExercicio.Biceps
            });
        }

        [TestMethod]
        public void Inativar()
        {
            Exercicio exercicio = new Exercicio
            {
                Nome = "Exercicio teste 3",
                Descricao = "Descricao teste 3",
                Tipo = Model.Enum.Exercicio.TipoExercicio.Abdominal
            };
            _exercicioService.Save(exercicio);

            Assert.IsTrue(_exercicioService.Inactivate(exercicio.Id));

            Assert.IsFalse(exercicio.Ativo);
        }

        [TestMethod]
        public void InativarComIdentificadorInexistente()
        {
            Assert.IsFalse(_exercicioService.Inactivate(10));
        }

        [TestCleanup()]
        public void CleanupAfterAllTests()
        {
            using (IExercicioContext context = new IoC().Resolve<IExercicioContext>())
            {
                IQueryable<Exercicio> exercicios = context.GetAll();

                if (exercicios.Any())
                {
                    Assert.IsTrue(context.DeleteRange(exercicios));
                }
            }
        }
    }
}
