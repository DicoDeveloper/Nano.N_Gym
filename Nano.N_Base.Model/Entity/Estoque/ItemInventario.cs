using Nano.N_Base.Model.Entity.ProdutoVinculos;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Estoque
{
    [Table("ITENS_INVENTARIOS")]
    public class ItemInventario : EntityBaseEmpresa
    {
        [ForeignKey("Produto")]
        public long IdProduto { get; set; }
        [ForeignKey("Lote")]
        public long? IdLote { get; set; }
        public decimal? QuantidadeContada { get; set; }
        public decimal? QuantidadeEstoque { get; set; }
        public DateTime? DataHoraContagem { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual LoteCorTamanho Lote { get; set; }
    }
}
