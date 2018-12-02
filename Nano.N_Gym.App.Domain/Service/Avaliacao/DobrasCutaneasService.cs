using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class DobrasCutaneasService : BaseService<DobrasCutaneas>, IDobrasCutaneasService
    {
        private readonly IDobrasCutaneasRepository _repository;

        public DobrasCutaneasService(IDobrasCutaneasRepository repository, IBaseValidation<DobrasCutaneas> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(DobrasCutaneas dobras)
        {
            // Executar verificacoes especificas
            return base.Save(dobras);
        }
    }
}
