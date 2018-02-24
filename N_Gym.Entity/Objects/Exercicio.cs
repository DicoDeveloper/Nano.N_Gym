using N_Gym.Entity.Enums.Exercicio;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("EXERCICIOS")]
    public class Exercicio
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID_EXERCICIO")]
        public long Id { get; set; }
        [Column("NOME"), Required]
        public string Nome { get; set; }
        [Column("TIPO"), Required]
        public TipoExercicio Tipo { get; set; }
        [Column("DESCRICAO")]
        public string Descricao { get; set; }
        public virtual ICollection<ExercicioTreino> Treinos { get; set; }
        #endregion
    }
}
