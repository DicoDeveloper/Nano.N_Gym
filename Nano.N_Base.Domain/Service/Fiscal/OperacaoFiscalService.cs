using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Domain.Interface.Service.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;

namespace Nano.N_Base.Domain.Service.Fiscal
{
    internal class OperacaoFiscalService : BaseService<OperacaoFiscal>, IOperacaoFiscalService
    {
        private readonly IOperacaoFiscalRepository _repository;

        public OperacaoFiscalService(IOperacaoFiscalRepository repository) : base(repository)
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
