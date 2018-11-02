using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class TransportadoraService : BaseService<Transportadora>, ITransportadoraService
    {
        private readonly ITransportadoraRepository _repository;

        public TransportadoraService(ITransportadoraRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Transportadora transportadora)
        {
            // Executar verificacoes especificas
            return base.Save(transportadora);
        }
    }
}
