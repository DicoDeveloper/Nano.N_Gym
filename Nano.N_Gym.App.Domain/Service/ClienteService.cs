using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ClienteService : GymBaseService<Cliente>, IClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository repository, IBaseValidation<Cliente> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Cliente cliente)
        {
            // Executar verificacoes especificas
            return base.Save(cliente);
        }
    }
}
