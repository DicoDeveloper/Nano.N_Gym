using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("RCQS")]
    public class RCQ : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        public decimal CinturaPerimetria { get; set; }
        public decimal QuadrilPerimetria { get; set; }
        public decimal? Valor { get; set; }
        [MaxLength(40)]
        public string Resultado { get; set; }

        public virtual AvaliacaoBase Base { get; set; }
    }
}
