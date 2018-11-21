using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.ProdutoVinculos
{
    [Table("CATEGORIAS")]
    public class Categoria : EntityBase
    {
        [MaxLength(80)]
        public string Descricao { get; set; }
        [ForeignKey("Pai")]
        public long? IdPai { get; set; }

        public virtual Categoria Pai { get; set; }
        public virtual IList<Produto> Produtos { get; set; }

        public Categoria()
        {
            Produtos = new List<Produto>();
        }
    }
}
