using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    public class ExercicioTreino
    {
        #region Propriedades
        public long ExercicioId { get; set; }
        public long TreinoId { get; set; }
        [Required]
        public int NumTreino { get; set; }
        [Required]
        public int NumExercicio { get; set; }
        [Required]
        public int Serie { get; set; }
        [Required]
        public int Repeticoes { get; set; }
        [Required]
        public string Intervalo { get; set; }
        public virtual Exercicio Exercicio { get; set; }
        public virtual Treino Treino { get; set; }
        #endregion
    }
}
