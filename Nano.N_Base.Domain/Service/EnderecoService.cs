using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Domain.Service
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
