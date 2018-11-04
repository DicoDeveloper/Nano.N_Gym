using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class ColaboradorBaseService : BaseService<ColaboradorBase>, IColaboradorBaseService
    {
        private readonly IColaboradorBaseRepository _repository;

        public ColaboradorBaseService(IColaboradorBaseRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(ColaboradorBase funcionario)
        {
            // Executar verificacoes especificas
            return base.Save(funcionario);
        }
    }
}
