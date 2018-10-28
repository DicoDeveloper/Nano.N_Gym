using Nano.N_Base.Model.Entity.ProdutoVinculos;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Estoque
{
    [Table("LIMITADORES_ESTOQUES")]
    public class LimitadorEstoque : EntityBasePorEmpresa
    {
        [ForeignKey("Produto")]
        public long IdProduto { get; set; }
        [ForeignKey("Lote")]
        public long? IdLote { get; set; }
        public decimal Minimo { get; set; }
        public decimal PontoCompra { get; set; }
        public decimal Maximo { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual LoteCorTamanho Lote { get; set; }
    }
}
