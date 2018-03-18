using System.ComponentModel.DataAnnotations.Schema;
using N_Sale.Entity.Enums;

namespace N_Sale.Entity.Objects
{
    public class ItemTroca : Item
    {
        #region Propriedades
        [ForeignKey("Troca")]
        public long IdTroca { get; set; }
        public DirecaoItemTroca Direcao { get; set; }
        public virtual Troca Troca { get; set; }
        #endregion
    }
}