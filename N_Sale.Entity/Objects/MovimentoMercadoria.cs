using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace N_Sale.Entity.Objects
{
    public class MovimentoMercadoria
    {
        #region Propriedades
        public long Id { get; set; }
        [MaxLength(30, ErrorMessage = "Numero de Documento não pode ultrpassar 30 caracteres")]
        public string NrDocumento { get => NrDocumento; set => NrDocumento = value.Length > 30 ? value.Substring(0, 30) : value; }
        public DateTime DataEmissao { get; set; }
        [Required(ErrorMessage = "Data movimento é obrigatória")]
        public DateTime DataMovimento { get; set; }
        public string Observacao { get; set; }
        [Range(0.01, 999999.99, ErrorMessage = "Valor total não pode ser zero"), Required]
        public decimal ValorTotal { get; set; }
        [Range(0.001, 999999.999, ErrorMessage = "Quantidade não pode ser zero"), Required]
        public virtual List<ItemMovimentoMercadoria> Itens { get; set; }
        #endregion

        public MovimentoMercadoria()
        {
            Itens = new List<ItemMovimentoMercadoria>();
        }
    }
}