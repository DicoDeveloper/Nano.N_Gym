using System.ComponentModel.DataAnnotations.Schema;

namespace N_Sale.Entity.Objects
{
    public class ItemVenda : Item
    {
        #region Propriedades
        [ForeignKey("Venda")]
        public long IdVenda { get; set; }
        public virtual Venda Venda { get; set; }
        #endregion
    }
}