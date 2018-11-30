using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Domain.Interface.Service.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Fiscal
{
    internal class ModeloFiscalService : BaseService<ModeloFiscal>, IModeloFiscalService
    {
        private readonly IModeloFiscalRepository _repository;

        public ModeloFiscalService(IModeloFiscalRepository repository, IBaseValidation<ModeloFiscal> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(ModeloFiscal modeloFiscal)
        {
            // Executar verificacoes especificas
            return base.Save(modeloFiscal);
        }
    }
}
