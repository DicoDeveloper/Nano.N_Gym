using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Domain.Interface.Service.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;

namespace Nano.N_Base.Domain.Service.Financeiro
{
    internal class CondicaoPagamentoService : BaseService<CondicaoPagamento>, ICondicaoPagamentoService
    {
        private readonly ICondicaoPagamentoRepository _repository;

        public CondicaoPagamentoService(ICondicaoPagamentoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(CondicaoPagamento condicaoPagamento)
        {
            // Executar verificacoes especificas
            return base.Save(condicaoPagamento);
        }
    }
}
