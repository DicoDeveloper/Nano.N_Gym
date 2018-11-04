using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("AVALIACOES_IMC")]
    public class AvaliacaoIMC : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        [Range(1, 250)]
        public int Estatura { get; set; }
        [Range(0.001, 999.999)]
        public decimal Peso { get; set; }

        public virtual AvaliacaoBase Base { get; set; }
    }
}
