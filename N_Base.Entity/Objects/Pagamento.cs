using N_Base.Entity.Enums.Pagamento;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class Pagamento
    {
        #region Popriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public TipoOperacaoPagamento TipoOperacao { get; set; }
        [Required]
        public FormaPagamento FormaPago { get; set; }
        [Range(0.01, 999999.99, ErrorMessage = "Valor de pagamento não pode ser zero"), Required]
        public decimal Valor { get; set; }
        [Range(0, 999999.99), Required]
        public decimal Troco { get; set; }
        public DateTime DataPago { get; set; }
        #endregion
    }
}
