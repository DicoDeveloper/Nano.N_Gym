using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Sale.Entity.Objects
{
    public class ContaReceberVenda
    {
        #region Propriedades
        [ForeignKey("ContaSuperior")]
        public long IdContaSuperior { get; set; }
        [ForeignKey("Venda")]
        public long IdVenda {get;set;}
        public virtual ContaReceberVenda ContaSuperior { get; set; }
        public virtual Venda Venda {get;set;}
        public virtual List<ContaReceberVenda> ContasInferiores { get; set; }
        #endregion

        public ContaReceberVenda() => ContasInferiores = new List<ContaReceberVenda>();
    }
}  