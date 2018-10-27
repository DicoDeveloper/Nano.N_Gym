using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class ProficaoService : BaseService<Proficao>, IProficaoService
    {
        private readonly IProficaoRepository _repository;

        public ProficaoService(IProficaoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Proficao proficao)
        {
            // Executar verificacoes especificas
            return base.Save(proficao);
        }
    }
}
