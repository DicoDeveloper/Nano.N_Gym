using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    public class ContratoModalidade
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [ForeignKey("Modalidade")]
        public long IdModalidade { get; set; }
        [ForeignKey("Contratao")]
        public long IdContrato { get; set; }
        public DateTime DataValidade { get; set; }
        [Required, Range(0.01, 999999.99)]
        public decimal ValorModalidade { get; set; }
        [Range(0, 999999.99)]
        public decimal ValorDesconto { get; set; }
        public virtual Modalidade Modalidade { get; set; }
        public virtual Contrato Contrato { get; set; }
        #endregion
    }
}
