using Nano.N_Base.Model.Entity.ProdutoVinculos;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Estoque
{
    [Table("ESTOQUES_MENSAIS")]
    public class EstoqueMensal : EntityBasePorEmpresa
    {
        [ForeignKey("Produto")]
        public long IdProduto { get; set; }
        [ForeignKey("Lote")]
        public long? IdLote { get; set; }
        public DateTime DataContabil { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? PrecoVenda { get; set; }
        public decimal? PrecoCusto { get; set; }
        public decimal? PrecoMedio { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual LoteCorTamanho Lote { get; set; }
    }
}
