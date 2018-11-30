using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Domain.Interface.Service.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Financeiro
{
    internal class TituloFinanceiroService : BaseService<TituloFinanceiro>, ITituloFinanceiroService
    {
        private readonly ITituloFinanceiroRepository _repository;

        public TituloFinanceiroService(ITituloFinanceiroRepository repository, IBaseValidation<TituloFinanceiro> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(TituloFinanceiro tituloFinanceiro)
        {
            // Executar verificacoes especificas
            return base.Save(tituloFinanceiro);
        }
    }
}
