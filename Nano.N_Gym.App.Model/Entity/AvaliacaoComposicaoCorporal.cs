using Nano.N_Base.Model.Entity;
using Nano.N_Gym.App.Model.Enum.Avaliacao;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("AVALIACOES_COMPOSICOES_CORPORAIS")]
    public class AvaliacaoComposicaoCorporal : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        [Range(0.001, 999.999)]
        public decimal Peso { get; set; }
        public Protocolo Protocolo { get; set; }
        public int? DCAbdominal { get; set; }
        public int? DCAxilaMedia { get; set; }
        public int? DCCoxa { get; set; }
        public int? DCPanturrilha { get; set; }
        public int? DCSubescapular { get; set; }
        public int? DCSuprailiaca { get; set; }
        public int? DCTorax { get; set; }
        public int? DCTriceps { get; set; }
        public decimal? MassaMagraKg { get; set; }
        public decimal? GorduraKg { get; set; }
        public decimal? MediaPesoIdealKg { get; set; }
        public decimal? PesoExtraKg { get; set; }
        public decimal? MassaMagraPercentual { get; set; }
        public decimal? GorduraPercentual { get; set; }
        public decimal? MediaGorduraPretendida { get; set; }
        public decimal? GorduraExtraPercentual { get; set; }        

        public virtual AvaliacaoBase Base { get; set; }
    }
}
