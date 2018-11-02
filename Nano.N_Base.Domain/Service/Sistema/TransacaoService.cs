using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class TransacaoService : BaseService<Transacao>, ITransacaoService
    {
        private readonly ITransacaoRepository _repository;

        public TransacaoService(ITransacaoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Transacao transacao)
        {
            // Executar verificacoes especificas
            return base.Save(transacao);
        }
    }
}
