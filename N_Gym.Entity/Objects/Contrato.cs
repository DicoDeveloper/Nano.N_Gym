using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using N_Base.Entity.Objects;

namespace N_Gym.Entity.Objects
{
    public class Contrato
    {
        #region Propriedades
        public long Id { get; set; }
        [ForeignKey("Cliente")]
        public long IdCliente { get; set; }
        [ForeignKey("Conta")]
        public long IdConta { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime Vencimento { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Conta Conta { get; set; }
        public virtual List<ContratoModalidade> ContratosModalidades
        { get; set; }
        #endregion
    }
}