using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Domain.Service
{
    internal class PessoaService : BaseService<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _repository;

        public PessoaService(IPessoaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Pessoa pessoa)
        {
            // Executar verificacoes especificas
            return base.Save(pessoa);
        }
    }
}
