using Nano.N_Base.Model.Entity;
using Nano.N_Gym.App.Model.Enum.Avaliacao;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("COMPOSICOES_CORPORAIS")]
    public class ComposicaoCorporal : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        [ForeignKey("DobrasCutaneas")]
        public long? IdDobrasCutaneas { get; set; }
        [ForeignKey("Perimetria")]
        public long? IdPerimetria { get; set; }
        [Range(0.001, 999.999)]
        public decimal Peso { get; set; }
        public Protocolo Protocolo { get; set; }
        public decimal? MassaMagraKg { get; set; }
        public decimal? GorduraKg { get; set; }
        public decimal? MediaPesoIdealKg { get; set; }
        public decimal? PesoExtraKg { get; set; }
        public decimal? MassaMagraPercentual { get; set; }
        public decimal? GorduraPercentual { get; set; }
        public decimal? MediaGorduraPretendida { get; set; }
        public decimal? GorduraExtraPercentual { get; set; }        
        public decimal? TMB { get; set; }        

        public virtual AvaliacaoBase Base { get; set; }
        public virtual DobrasCutaneas DobrasCutaneas { get; set; }
        public virtual Perimetria Perimetria { get; set; }
    }
}
