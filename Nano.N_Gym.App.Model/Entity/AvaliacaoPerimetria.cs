using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("AVALIACOES_PERIMETRIAS")]
    public class AvaliacaoPerimetria : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        public int? ToraxPerimetria { get; set; }
        public int? BracoDireitoPerimetria { get; set; }
        public int? AntebracoDireitoPerimetria { get; set; }
        public int? BracoEsquerdoPerimetria { get; set; }
        public int? AntebracoEsquerdoPerimetria { get; set; }
        public int? CoxaDireitaPerimetria { get; set; }
        public int? PanturrilhaDireitaPerimetria { get; set; }
        public int? CoxaEsquerdaPerimetria { get; set; }
        public int? PanturrilhaEsquerdaPerimetria { get; set; }
        [ForeignKey("RCQ")]
        public long? IdRCQ { get; set; }
        [ForeignKey("RiscoCoronariano")]
        public long? IdRiscoCoronariano { get; set; }

        public virtual AvaliacaoBase Base { get; set; }
        public virtual AvaliacaoRCQ RCQ { get; set; }
        public virtual AvaliacaoRiscoCoronariano RiscoCoronariano { get; set; }
    }
}
