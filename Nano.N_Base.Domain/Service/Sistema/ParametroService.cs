using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class ParametroService : BaseService<Parametro>, IParametroService
    {
        private readonly IParametroRepository _repository;

        public ParametroService(IParametroRepository repository, IBaseValidation<Parametro> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Parametro parametro)
        {
            // Executar verificacoes especificas
            return base.Save(parametro);
        }
    }
}
