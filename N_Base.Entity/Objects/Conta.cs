using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class Conta
    {
        #region Propriedades
        public long Id { get; set; }
        [ForeignKey("CentroCusto")]
        public long IdCentroCusto { get; set; }

        public virtual List<Pagamento> Pagamentos { get; set; }
        public virtual CentroCusto CentroCusto { get; set; }
        #endregion

        public Conta() => Pagamentos = new List<Pagamento>();
    }
}