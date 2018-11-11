using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class QuestionarioAhaService : GymBaseService<QuestionarioAha>, IQuestionarioAhaService
    {
        private readonly IQuestionarioAhaRepository _repository;

        public QuestionarioAhaService(IQuestionarioAhaRepository repository) : base(repository)
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
