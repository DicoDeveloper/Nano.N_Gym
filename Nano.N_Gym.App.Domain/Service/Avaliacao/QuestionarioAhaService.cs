using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class QuestionarioAhaService : BaseService<QuestionarioAha>, IQuestionarioAhaService
    {
        private readonly IQuestionarioAhaRepository _repository;

        public QuestionarioAhaService(IQuestionarioAhaRepository repository, IBaseValidation<QuestionarioAha> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(QuestionarioAha avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
