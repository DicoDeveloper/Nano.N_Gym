using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ImagemService : BaseService<Imagem>, IImagemService
    {
        private readonly IImagemRepository _repository;

        public ImagemService(IImagemRepository repository, IBaseValidation<Imagem> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Imagem imagem)
        {
            // Executar verificacoes especificas
            return base.Save(imagem);
        }
    }
}
