using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Sale.Entity.Objects
{
    public class Perda
    {
        #region Propriedades
        public long Id { get; set; }
        [ForeignKey("Produto"), Required(ErrorMessage = "É preciso selecionar um produto para a perda")]
        public long IdProduto { get; set; }
        [MaxLength(50, ErrorMessage = "Motivo não pode ultrapassar 50 caracteres")]
        public string Observacao { get; set; }
        public DateTime Data { get; set; }
        [Range(0.001, 999999.999, ErrorMessage = "Quantidade não pode ser zero"), Required]
        public decimal Qtd { get; set; }
        [Range(0.01, 999999.99, ErrorMessage = "Valor não pode ser zero")]
        public decimal Valor { get; set; }
        public virtual Produto Produto { get; set; }
        #endregion
    }
}