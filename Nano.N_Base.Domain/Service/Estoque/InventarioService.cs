using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Domain.Service.Estoque
{
    internal class InventarioService : BaseService<Inventario>, IInventarioService
    {
        private readonly IInventarioRepository _repository;

        public InventarioService(IInventarioRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Inventario Inventario)
        {
            // Executar verificacoes especificas
            return base.Save(Inventario);
        }
    }
}
