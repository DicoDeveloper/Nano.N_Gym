using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class FabricanteService : BaseService<Fabricante>, IFabricanteService
    {
        private readonly IFabricanteRepository _repository;

        public FabricanteService(IFabricanteRepository repository, IBaseValidation<Fabricante> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Fabricante fabricante)
        {
            // Executar verificacoes especificas
            return base.Save(fabricante);
        }
    }
}
