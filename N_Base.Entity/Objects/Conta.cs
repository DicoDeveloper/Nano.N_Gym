using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class Conta
    {
        #region Propriedades
        public long Id { get; set; }
        [ForeignKey("ContaSuperior")]
        public long IdContaSupereior { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
         public bool Cancelado { get; set; }
        public virtual Conta ContaSuperior { get; set; }
        public virtual List<Conta> ContasInferiores { get; set; }
        public virtual List<Pagamento> Pagamentos { get; set; }       
        #endregion

        public Conta()
        {
            ContasInferiores = new List<Conta>();
            Pagamentos = new List<Pagamento>();
        }
    }
}