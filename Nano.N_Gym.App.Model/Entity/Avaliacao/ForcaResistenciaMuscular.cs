using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("FORCA_RESISTENCIAS_MUSCULARES")]
    public class ForcaResistenciaMuscular : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        public decimal Abdominal { get; set; }
        public decimal BraquioPeitoral { get; set; }
        public decimal MediaPressaoManualDireita { get; set; }
        public decimal MediaPressaoManualEsquerda { get; set; }

        public virtual AvaliacaoBase Base { get; set; }
    }
}
