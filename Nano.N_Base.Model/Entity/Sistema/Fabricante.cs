using Nano.N_Base.Model.Entity.ProdutoVinculos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("FABRICANTES")]
    public class Fabricante : EntityBase
    {
        [MaxLength(100)]
        public string RasaoSocial { get; set; }
        [MaxLength(20)]
        public string Cnpj { get; set; }

        public virtual IList<Produto> Produtos { get; set; }

        public Fabricante()
        {
            Produtos = new List<Produto>();
        }
    }
}
