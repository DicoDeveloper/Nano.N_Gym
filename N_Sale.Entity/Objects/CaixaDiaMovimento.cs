using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using N_Sale.Entity.Enums;

namespace N_Sale.Entity.Objects
{
    public class CaixaDiaMovimento
    {
        #region Propriedades
        public long Id { get; set; }
        [ForeignKey("Caixa"), Required]
        public long IdCaixaDia { get; set; }
        public TipoMovimentoCaixa TipoOperacao { get; set; }
        [MaxLength(150, ErrorMessage = "Descrição do movimento não pode ultrapassar 150 caracteres"), Required(ErrorMessage = "Descrição do movimento é obrigatória")]
        public string Descricao { get => Descricao; set => Descricao = value.Length > 150 ? value.Substring(0, 150) : value; }
        [Range(0.01, 999999.99, ErrorMessage = "Valor do movimento não pode ser zero"), Required(ErrorMessage = "É nescessario informar o valor do movimento")]
        public decimal Valor { get; set; }
        [MaxLength(5), Required(ErrorMessage = "É obrigatório informar o horario do movimento")]
        public string Horario { get; set; }
        public virtual CaixaDia Caixa { get; set; }
        #endregion
    }
}