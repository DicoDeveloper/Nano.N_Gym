using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class ClienteBaseService : BaseService<ClienteBase>, IClienteBaseService
    {
        private readonly IClienteBaseRepository _repository;

        public ClienteBaseService(IClienteBaseRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(ClienteBase cliente)
        {
            // Executar verificacoes especificas
            return base.Save(cliente);
        }
    }
}
