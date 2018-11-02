using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class ContatoService : BaseService<Contato>, IContatoService
    {
        private readonly IContatoRepository _repository;

        public ContatoService(IContatoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Contato contato)
        {
            // Executar verificacoes especificas
            return base.Save(contato);
        }
    }
}
