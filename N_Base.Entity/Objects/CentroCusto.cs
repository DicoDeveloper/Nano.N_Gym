using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    [Table("CENTRO_CUSTOS")]
    public class CentroCusto
    {
        #region Propriedades
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_CENTRO_CUSTO")]
        public long Id { get; set; }
        [MaxLength(200, ErrorMessage = "Descrição não pode passar de 200 caracteres"), Required(ErrorMessage = "Descrição é obrigatório")]
        [Column("DESCRICAO")]
        public string Descricao { get => Descricao; set => Descricao = value.Length > 200 ? value.Substring(0, 200) : value; }
        [Range(0.01, 999999.99, ErrorMessage = "Centro de custo não pode ter valor zero"), Required(ErrorMessage = "Valor é obrigatório")]
        [Column("VAL_CENTRO_CUSTO")]
        public decimal Valor { get; set; }
        [Column("DAT_VENCIMENTO")]
        public DateTime DataVencimento { get; set; }
        [Column("DAT_PAGAMENTO")]
        public DateTime DataPagamento { get; set; }
        [Column("CUSTO_FIXO"), Required]
        public bool CustoFixo { get; set; }
        [Column("ESTA_PAGO"), Required]
        public bool EstaPago { get; set; }
        #endregion
    }
}
