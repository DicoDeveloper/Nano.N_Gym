using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("EXERCICIOS_TREINOS")]
    public class ExercicioTreino : EntityBase
    {
        [ForeignKey("Treino"), Required]
        public long IdTreino { get; set; }
        [Required]
        public int NumeroOrdem { get; set; }
        [Required]
        public int QuantidadeSerie { get; set; }
        [Required]
        public int QuantidadeRepeticao { get; set; }
        [Required]
        public string TempoIntervalo { get; set; }

        public virtual Treino Treino { get; set; }
    }
}
