using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class TransacaoService : BaseService<Transacao>, ITransacaoService
    {
        private readonly ITransacaoRepository _repository;

        public TransacaoService(ITransacaoRepository repository, IBaseValidation<Transacao> validation) : base(repository, validation)
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
