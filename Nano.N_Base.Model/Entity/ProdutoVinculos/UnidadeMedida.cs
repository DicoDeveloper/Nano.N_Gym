using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.ProdutoVinculos
{
    [Table("UNIDADES_MEDIDAS")]
    public class UnidadeMedida : EntityBase
    {
        [MaxLength(150)]
        public string Nome { get; set; }
        public decimal FatorConvercao { get; set; }

        public virtual IList<Produto> Produtos { get; set; }
        public virtual IList<CodigoProduto> Codigos { get; set; }

        public UnidadeMedida()
        {
            Produtos = new List<Produto>();
            Codigos = new List<CodigoProduto>();
        }
    }
}
