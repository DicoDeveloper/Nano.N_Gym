using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace N_Sale.Entity.Objects
{
    public class CaixaDia
    {
        #region Propriedades
        public long Id { get; set; }
        [Required(ErrorMessage = "Data do caixa é obrigatório")]
        public DateTime Data { get; set; }
        [Range(0, 999999.99, ErrorMessage = "Valor inicial não pode ser negativo"), Required(ErrorMessage = "Valor inicial é obrigatório")]
        public decimal ValorInicial { get; set; }
        [Range(0, 999999.99, ErrorMessage = "Vaor final não pode ser negativo")]
        public decimal ValorFinal { get; set; }
        [Range(1, 999), Required(ErrorMessage = "É nescessario informar um numero de caixa")]
        public long Numero { get; set; }
        public virtual List<CaixaDiaMovimento> Movimentos { get; set; }
        #endregion

        public CaixaDia() => Movimentos = new List<CaixaDiaMovimento>();
    }
}