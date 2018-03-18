using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using N_Gym.Entity.Objects;

namespace N_Sale.Entity.Objects
{
    public class Pedido : MovimentoMercadoria
    {
        #region Propriedades
        [ForeignKey("Cliente")]
        [Required(ErrorMessage = "É obrigatório informar um Cliente")]
        public long IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual List<ContaReceberPedido> ContasReceber {get;set;}
        #endregion
    }
}