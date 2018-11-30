using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Domain.Interface.Service.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Fiscal
{
    internal class OperacaoFiscalService : BaseService<OperacaoFiscal>, IOperacaoFiscalService
    {
        private readonly IOperacaoFiscalRepository _repository;

        public OperacaoFiscalService(IOperacaoFiscalRepository repository, IBaseValidation<OperacaoFiscal> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(OperacaoFiscal operacaoFiscal)
        {
            // Executar verificacoes especificas
            return base.Save(operacaoFiscal);
        }
    }
}
