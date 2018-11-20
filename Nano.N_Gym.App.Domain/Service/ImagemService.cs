using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ImagemService : GymBaseService<Imagem>, IImagemService
    {
        private readonly IImagemRepository _repository;

        public ImagemService(IImagemRepository repository) : base(repository)
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
