using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Domain.Interface.Service.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;

namespace Nano.N_Base.Domain.Service.Financeiro
{
    internal class MovimentoFinanceiroService : BaseService<MovimentoFinanceiro>, IMovimentoFinanceiroService
    {
        private readonly IMovimentoFinanceiroRepository _repository;

        public MovimentoFinanceiroService(IMovimentoFinanceiroRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(MovimentoFinanceiro movimentacaoFinanceira)
        {
            // Executar verificacoes especificas
            return base.Save(movimentacaoFinanceira);
        }
    }
}
