using Nano.N_Base.Model.Enum.Inventario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Estoque
{
    [Table("INVENTARIOS")]
    public class Inventario : EntityBaseEmpresa
    {
        [MaxLength(30)]
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        public TipoBloqueioProduto TipoBloqueio { get; set; }

        public virtual IList<ItemInventario> ItensInventario { get; set; }

        public Inventario()
        {
            ItensInventario = new List<ItemInventario>();
        }
    }
}
