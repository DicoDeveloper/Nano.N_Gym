using N_Base.Entity.Enums.Pagamento;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    [Table("PAGAMENTOS")]
    public class Pagamento
    {
        #region Popriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_PAGAMENTO")]
        public long Id { get; set; }
        [Column("TIPO_OPERACAO"), Required]
        public TipoOperacaoPagamento TipoOperacao { get; set; }
        [Column("FORMA_PAGAMENTO"), Required]
        public FormaPagamento FormaPago { get; set; }
        [Range(0.01, 999999.99, ErrorMessage = "Valor de pagamento não pode ser zero"), Column("VAL_PAGAMENTO"), Required]
        public decimal Valor { get; set; }
        [Range(0, 999999.99), Required, Column("VAL_TROCO")]
        public decimal Troco { get; set; }
        [Column("DAT_PAGAMENTO")]
        public DateTime DataPago { get; set; }
        #endregion
    }
}
