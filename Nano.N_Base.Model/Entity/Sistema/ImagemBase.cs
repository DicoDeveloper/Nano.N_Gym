using Nano.N_Base.Model.Entity.ProdutoVinculos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("IMAGENS_BASE")]
    public class ImagemBase : EntityBase
    {
        public int Sequencia { get; set; }
        public byte[] Arquivo { get; set; }
        [MaxLength(80)]
        public string Nome { get; set; }
        public bool Principal { get; set; }

        public virtual IList<Produto> Produtos { get; set; }

        public ImagemBase()
        {
            Produtos = new List<Produto>();
        }
    }
}
