using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class ComposicaoCorporalService : BaseService<ComposicaoCorporal>, IComposicaoCorporalService
    {
        private readonly IComposicaoCorporalRepository _repository;

        public ComposicaoCorporalService(IComposicaoCorporalRepository repository, IBaseValidation<ComposicaoCorporal> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(ComposicaoCorporal avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
