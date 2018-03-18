using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using N_Base.Entity.Objects;

namespace N_Sale.Entity.Objects
{
    public class ContaReceberPedido : Conta
    {
        #region Propriedades
        [ForeignKey("ContaSuperior")]
        public long IdContaSuperior { get; set; }
        [ForeignKey("Pedido")]
        public long IdPedido {get;set;}
        public virtual ContaReceberPedido ContaSuperior { get; set; }
        public virtual Pedido Pedido {get;set;}
        public virtual List<ContaReceberPedido> ContasInferiores { get; set; }
        #endregion

        public ContaReceberPedido() => ContasInferiores = new List<ContaReceberPedido>();
    }
}