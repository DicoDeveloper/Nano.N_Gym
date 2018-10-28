using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.ProdutoVinculos
{
    [Table("PRODUTOS")]
    public class Produto : EntityBase
    {
        [MaxLength(150)]
        public string Nome { get; set; }

        public virtual IList<LoteCorTamanho> Lotes { get; set; }

        public Produto()
        {
            Lotes = new List<LoteCorTamanho>();
        }
    }
}
