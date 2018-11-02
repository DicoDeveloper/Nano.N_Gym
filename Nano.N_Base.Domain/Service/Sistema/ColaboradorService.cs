using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class ColaboradorService : BaseService<Colaborador>, IColaboradorService
    {
        private readonly IColaboradorRepository _repository;

        public ColaboradorService(IColaboradorRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Colaborador funcionario)
        {
            // Executar verificacoes especificas
            return base.Save(funcionario);
        }
    }
}
