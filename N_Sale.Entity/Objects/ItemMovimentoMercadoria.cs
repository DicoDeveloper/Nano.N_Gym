using System.ComponentModel.DataAnnotations.Schema;

namespace N_Sale.Entity.Objects
{
    public class ItemMovimentoMercadoria : Item
    {
        #region Propriedades
        [ForeignKey("MovMercadoria")]
        public long IdMovimentoMercadoria { get; set; }
        public virtual MovimentoMercadoria MovMercadoria { get; set; }
        #endregion
    }
}