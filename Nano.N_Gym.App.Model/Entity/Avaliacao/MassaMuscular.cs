using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("MASSAS_MUSCULARES")]
    public class MassaMuscular : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        [Range(1, 250)]
        public int Estatura { get; set; }
        public decimal BracoPerimetriaCorrigida { get; set; }
        public decimal CoxaPerimetriaCorrigida { get; set; }
        public decimal PanturrilhaPerimetriaCorrigida { get; set; }
        public decimal Resultado { get; set; }

        public virtual AvaliacaoBase Base { get; set; }
    }
}
