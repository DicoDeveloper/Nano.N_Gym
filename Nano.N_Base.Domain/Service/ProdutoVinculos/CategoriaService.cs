using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.ProdutoVinculos
{
    internal class CategoriaService : BaseService<Categoria>, ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository, IBaseValidation<Categoria> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Categoria categoria)
        {
            // Executar verificacoes especificas
            return base.Save(categoria);
        }
    }
}
