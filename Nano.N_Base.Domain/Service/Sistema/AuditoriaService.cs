using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class AuditoriaService : BaseService<Auditoria>, IAuditoriaService
    {
        private readonly IAuditoriaRepository _repository;

        public AuditoriaService(IAuditoriaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Auditoria auditoria)
        {
            // Executar verificacoes especificas
            return base.Save(auditoria);
        }
    }
}
