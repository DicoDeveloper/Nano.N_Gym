using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("EXERCICIOS_TREINOS")]
    public class ExercicioTreino
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_EXERCICIOS_TREINOS")]
        public long Id { get; set; }
        [Column("ID_EXERCICIO"), ForeignKey("Exercicio")]
        public long IdExercicio { get; set; }
        [Column("ID_TREINO"), ForeignKey("Treino")]
        public long IdTreino { get; set; }
        [Column("NUM_TREINO"), Required]
        public int NumTreino { get; set; }
        [Column("NUM_EXERCICIO"), Required]
        public int NumExercicio { get; set; }
        [Column("NUM_SERIE"), Required]
        public int Serie { get; set; }
        [Column("NUM_REPETICOES"), Required]
        public int Repeticoes { get; set; }
        [Column("INTERVALO"), Required]
        public string Intervalo { get; set; }
        public virtual Exercicio Exercicio { get; set; }
        public virtual Treino Treino { get; set; }
        #endregion
    }
}
