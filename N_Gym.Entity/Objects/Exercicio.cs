using N_Gym.Entity.Enums.Exercicio;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    public class Exercicio
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public TipoExercicio Tipo { get; set; }
        public string Descricao { get; set; }
        public virtual List<ExercicioTreino> Treinos { get; set; }
        #endregion
    }
}
