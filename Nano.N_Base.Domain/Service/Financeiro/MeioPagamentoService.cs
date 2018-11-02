using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Domain.Interface.Service.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;

namespace Nano.N_Base.Domain.Service.Financeiro
{
    internal class MeioPagamentoService : BaseService<MeioPagamento>, IMeioPagamentoService
    {
        private readonly IMeioPagamentoRepository _repository;

        public MeioPagamentoService(IMeioPagamentoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(MeioPagamento meioPagamento)
        {
            // Executar verificacoes especificas
            return base.Save(meioPagamento);
        }
    }
}
