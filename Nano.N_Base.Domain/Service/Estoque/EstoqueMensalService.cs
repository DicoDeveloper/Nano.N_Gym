using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Model.Entity.Estoque;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Estoque
{
    internal class EstoqueMensalService : BaseService<EstoqueMensal>, IEstoqueMensalService
    {
        private readonly IEstoqueMensalRepository _repository;

        public EstoqueMensalService(IEstoqueMensalRepository repository, IBaseValidation<EstoqueMensal> validation) : base(repository, validation)
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
