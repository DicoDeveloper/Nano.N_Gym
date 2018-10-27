using Nano.N_Base.Data.Interface.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Data.Infra.Estoque
{
    public class EstoqueProdutoContext : BaseContext<Model.Entity.Estoque.EstoqueProduto>, IEstoqueProdutoContext
    {
    }
}
