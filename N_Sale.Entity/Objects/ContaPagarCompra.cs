using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using N_Base.Entity.Objects;

namespace N_Sale.Entity.Objects
{
    public class ContaPagarCompra : Conta
    {
        #region Propriedades
        [ForeignKey("ContaSuperior")]
        public long IdContaSuperior { get; set; }
        [ForeignKey("Compra")]
        public long IdCompra {get;set;}
        public virtual ContaPagarCompra ContaSuperior { get; set; }
        public virtual Compra Compra {get;set;}
        public virtual List<ContaPagarCompra> ContasInferiores { get; set; }
        #endregion

        public ContaPagarCompra() => ContasInferiores = new List<ContaPagarCompra>();
    }
}