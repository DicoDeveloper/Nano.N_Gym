using Nano.N_Base.Model.Entity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("AVALIACOES_BASE")]
    public class AvaliacaoBase : EntityBaseEmpresa
    {
        [ForeignKey("Cliente")]
        public long IdCliente { get; set; }
        [ForeignKey("Colaborador")]
        public long? IdColaorador { get; set; }
        public DateTime Data { get; set; }
        [Range(1, 120)]
        public int Idade { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Colaborador Colaborador { get; set; }
    }
}
