using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _repository;

        public EnderecoService(IEnderecoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Endereco endereco)
        {
            // Executar verificacoes especificas
            return base.Save(endereco);
        }
    }
}
