using Nano.N_Base.Model.Entity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("PAR_QS")]
    public class PARQ : EntityBase
    {
        [ForeignKey("Cliente")]
        public long? IdCliente { get; set; }
        [ForeignKey("Colaborador")]
        public long IdColaborador { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public bool _1 { get; set; }
        public bool _2 { get; set; }
        public bool _3 { get; set; }
        public bool _4 { get; set; }
        public bool _5 { get; set; }
        public bool _6 { get; set; }
        public bool _7 { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Colaborador Colaborador { get; set; }
    }
}
