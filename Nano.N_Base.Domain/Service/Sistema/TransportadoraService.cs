using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class TransportadoraService : BaseService<Transportadora>, ITransportadoraService
    {
        private readonly ITransportadoraRepository _repository;

        public TransportadoraService(ITransportadoraRepository repository, IBaseValidation<Transportadora> validation) : base(repository, validation)
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
