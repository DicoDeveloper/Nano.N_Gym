using Nano.N_Base.Model.Entity.ProdutoVinculos;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Estoque
{
    [Table("ESTOQUES_PRODUTOS")]
    public class EstoqueProduto : EntityBasePorEmpresa
    {
        [ForeignKey("Produto")]
        public long IdProduto { get; set; }
        [ForeignKey("Lote")]
        public long? IdLote { get; set; }
        public decimal? Quantidade { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual LoteCorTamanho Lote { get; set; }
    }
}
