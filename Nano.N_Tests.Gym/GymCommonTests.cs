using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Model.Entity;
using Nano.N_IoC;
using System;
using System.Linq;

namespace Nano.N_Gym.App.Tests.Domain
{
    internal class GymCommonTests
    {
        private readonly IoC _ioC;

        public GymCommonTests(IoC ioC)
        {
            _ioC = ioC;
        }

        public Empresa DefinirEmpresa(string codigo)
        {
            if (_ioC == null) return null;

            using (IEmpresaContext context = _ioC.Resolve<IEmpresaContext>())
            {
                Empresa empresa = context.GetAll().FirstOrDefault(e => e.NomeFantasia.Equals("Empresa teste " + codigo));

                if (empresa == null)
                {
                    empresa = new Empresa
                    {
                        Cadastrado = DateTime.Now.Date,
                        CPF_CNPJ = "00.000.000/0001-00",
                        Nome = $"Empresa teste {codigo}",
                        NomeFantasia = $"Empresa teste {codigo}",

                    };

                    context.Save(empresa);
                }
                else
                    empresa = context.GetById(empresa.Id);

                return empresa;
            }
        }

        public Aparelho DefinirAparelhoComLocalizacao(Localizacao localizacao)
        {
            if (_ioC == null) return null;

            using (IAparelhoContext context = _ioC.Resolve<IAparelhoContext>())
            {
                Aparelho aparelho = context.GetAll().FirstOrDefault(e => e.Nome.Equals("Teste delete"));

                if (aparelho == null)
                {
                    aparelho = new Aparelho
                    {
                        Nome = "Teste delete",
                        Localizacao = localizacao,
                        Empresa = localizacao.Empresa
                    };

                    context.Save(aparelho);
                }
                else
                    aparelho = context.GetById(aparelho.Id);

                return aparelho;
            }
        }
    }
}
