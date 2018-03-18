using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Sale.Entity.Objects
{
    public class Item
    {
        #region Propriedades
        public long Id { get; set; }
        [ForeignKey("Produto")]
        public long IdProduto { get; set; }
        [Range(0.001, 999999.999)]
        public decimal Qtd { get; set; }
        [Range(0.01, 999999.99)]
        public decimal Valor { get; set; }
        public virtual Produto Produto { get; set; }
        #endregion
    }
}