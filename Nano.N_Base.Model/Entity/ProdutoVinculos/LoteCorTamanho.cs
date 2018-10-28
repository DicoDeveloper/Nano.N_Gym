using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.ProdutoVinculos
{
    [Table("LOTES_CORES_TAMANHOS")]
    public class LoteCorTamanho : EntityBase
    {
        [ForeignKey("Cor")]
        public long IdCor { get; set; }
        [ForeignKey("Tamanho")]
        public long IdTamanho { get; set; }
        [MaxLength(40)]
        public string Descricao { get; set; }

        public virtual LoteCor Cor { get; set; }
        public virtual LoteTamanho Tamanho { get; set; }
        public virtual IList<Produto> Produtos { get; set; }

        public LoteCorTamanho()
        {
            Produtos = new List<Produto>();
        }
    }
}
