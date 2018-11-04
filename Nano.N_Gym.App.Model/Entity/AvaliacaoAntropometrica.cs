using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("AVALIACOES_ANTROPOMETRICAS")]
    public class AvaliacaoAntropometrica : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        public decimal? PressaoArterial { get; set; }
        public decimal? FCRepouso { get; set; }
        public decimal? Flexibilidade { get; set; }        
        
        public virtual AvaliacaoBase Base { get; set; }
    }
}
