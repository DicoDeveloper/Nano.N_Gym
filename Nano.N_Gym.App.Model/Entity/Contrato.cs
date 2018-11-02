using Nano.N_Base.Model.Entity;
using Nano.N_Base.Model.Entity.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("CONTRATOS")]
    public class Contrato : EntityBaseEmpresa
    {
        public string Descricao { get; set; }
        [ForeignKey("Cliente")]
        public long IdCliente { get; set; }
        [ForeignKey("Transacao")]
        public long IdTransacao { get; set; }
        [MaxLength(20)]
        public string NumeroDocumento { get; set; }
        public DateTime? Vencimento { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Transacao Transacao { get; set; }
        public virtual IList<Modalidade> Modalidades { get; set; }
    }
}
