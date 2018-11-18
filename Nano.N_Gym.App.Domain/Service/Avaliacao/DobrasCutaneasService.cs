using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class DobrasCutaneasService : GymBaseService<DobrasCutaneas>, IDobrasCutaneasService
    {
        private readonly IDobrasCutaneasRepository _repository;

        public DobrasCutaneasService(IDobrasCutaneasRepository repository) : base(repository)
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
