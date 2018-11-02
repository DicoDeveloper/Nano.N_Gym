using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Model.Enum.Produto;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.ProdutoVinculos
{
    [Table("PRODUTOS")]
    public class Produto : EntityBase
    {
        [ForeignKey("UnidadeMedida")]
        public long IdUnidadeMedida { get; set; }
        [ForeignKey("Fabricante")]
        public long? IdFabricante { get; set; }
        [MaxLength(150)]
        public string Descricao { get; set; }
        [MaxLength(50)]
        public string Abreviacao { get; set; }
        public TipoLote TipoLote { get; set; }

        public virtual UnidadeMedida UnidadeMedida { get; set; }
        public virtual Fabricante Fabricante { get; set; }
        public virtual IList<LoteCorTamanho> Lotes { get; set; }        

        public Produto()
        {
            Lotes = new List<LoteCorTamanho>();
        }
    }
}
