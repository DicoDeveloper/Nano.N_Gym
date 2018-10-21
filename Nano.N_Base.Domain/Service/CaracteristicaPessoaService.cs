using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Domain.Service
{
    internal class CaracteristicaPessoaService : BaseService<CaracteristicaPessoa>, ICaracteristicaPessoaService
    {
        private readonly ICaracteristicaPessoaRepository _repository;

        public CaracteristicaPessoaService(ICaracteristicaPessoaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(CaracteristicaPessoa caracteristicaPessoa)
        {
            // Executar verificacoes especificas
            return base.Save(caracteristicaPessoa);
        }
    }
}
