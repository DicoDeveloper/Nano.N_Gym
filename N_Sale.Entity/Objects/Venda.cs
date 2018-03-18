using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using N_Base.Entity.Objects;
using N_Gym.Entity.Objects;

namespace N_Sale.Entity.Objects
{
    public class Venda
    {
        #region Propriedades
        public long Id { get; set; }
        public DateTime Data { get; set; }
        [Range(0, 999999.99, ErrorMessage = "Valor do desconto não pode ser negativo")]
        public decimal Desconto { get; set; }
        [Range(0, 999999.99, ErrorMessage = "Valor do acrescimo não pode ser negativo")]
        public decimal Acrescimo { get; set; }
        [Range(0.01, 999999.99, ErrorMessage = "Valor da venda não pode ser zero")]
        public decimal ValorTotal { get; set; }
        [ForeignKey("Usuario"), Required]
        public long IdUsuario { get; set; }
        [ForeignKey("Cliente")]
        public long IdCliente { get; set; }
        public virtual List<ItemVenda> Itens { get; set; }
        public virtual List<Troca> Trocas { get; set; }
        public virtual List<ContaReceberVenda> ContasReceber { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Cliente Cliente { get; set; }
        #endregion

        public Venda()
        {
            Itens = new List<ItemVenda>();
            Trocas = new List<Troca>();
            ContasReceber = new List<ContaReceberVenda>();
        }
    }
}