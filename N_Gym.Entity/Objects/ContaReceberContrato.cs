using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using N_Base.Entity.Objects;

namespace N_Gym.Entity.Objects
{
    public class ContaReceberContrato : Conta
    {
        #region Propriedades
        [ForeignKey("ContaSuperior")]
        public long IdContaSuperior { get; set; }
        [ForeignKey("Contrato")]
        public long IdContrato {get;set;}
        public virtual ContaReceberContrato ContaSuperior { get; set; }
        public virtual Contrato Contrato {get;set;}
        public virtual List<ContaReceberContrato> ContasInferiores { get; set; }
        #endregion

        public ContaReceberContrato() => ContasInferiores = new List<ContaReceberContrato>();
    }
}