using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.ProdutoVinculos
{
    [Table("CODIGOS_PRODUTOS")]
    public class CodigoProduto : EntityBase
    {
        [ForeignKey("Produto")]
        public long IdProduto { get; set; }
        [ForeignKey("UnidadeMedida")]
        public long IdUnidadeMedida { get; set; }
        [MaxLength(20)]
        public string Codigo { get; set; }
        public bool Fiscal { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
    }
}
