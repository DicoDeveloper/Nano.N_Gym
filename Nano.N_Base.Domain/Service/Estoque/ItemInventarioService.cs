using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Model.Entity.Estoque;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Estoque
{
    internal class ItemInventarioService : BaseService<ItemInventario>, IItemInventarioService
    {
        private readonly IItemInventarioRepository _repository;

        public ItemInventarioService(IItemInventarioRepository repository, IBaseValidation<ItemInventario> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(ItemInventario ItemInventario)
        {
            // Executar verificacoes especificas
            return base.Save(ItemInventario);
        }
    }
}
