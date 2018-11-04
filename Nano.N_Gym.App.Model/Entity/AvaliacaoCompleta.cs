using Nano.N_Base.Model.Entity;
using Nano.N_Gym.App.Model.Enum.Avaliacao;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("AVALIACOES_COMPLETAS")]
    public class AvaliacaoCompleta : EntityBase
    {
        [ForeignKey("Antropometrica")]
        public long IdAntropometrica { get; set; }
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        [ForeignKey("ComposicaoCorporal")]
        public long? IdComposicaoCorporal { get; set; }
        [ForeignKey("IMC")]
        public long? IdIMC { get; set; }
        [ForeignKey("Perimetria")]
        public long? IdPerimetria { get; set; }
        [ForeignKey("RCQ")]
        public long? IdRCQ { get; set; }
        [ForeignKey("RiscoCoronariano")]
        public long? IdRiscoCoronariano { get; set; }
        public StatusAvaliacao Status { get; set; }

        public virtual AvaliacaoAntropometrica Antropometrica { get; set; }
        public virtual AvaliacaoBase Base { get; set; }
        public virtual AvaliacaoComposicaoCorporal ComposicaoCorporal { get; set; }
        public virtual AvaliacaoIMC IMC { get; set; }
        public virtual AvaliacaoPerimetria Perimetria { get; set; }
        public virtual AvaliacaoRCQ RCQ { get; set; }
        public virtual AvaliacaoRiscoCoronariano RiscoCoronariano { get; set; }
    }
}
