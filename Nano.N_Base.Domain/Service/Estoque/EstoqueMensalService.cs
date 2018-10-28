using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Domain.Service.Estoque
{
    internal class EstoqueMensalService : BaseService<EstoqueMensal>, IEstoqueMensalService
    {
        private readonly IEstoqueMensalRepository _repository;

        public EstoqueMensalService(IEstoqueMensalRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(EstoqueMensal estoqueMensal)
        {
            // Executar verificacoes especificas
            return base.Save(estoqueMensal);
        }
    }
}
