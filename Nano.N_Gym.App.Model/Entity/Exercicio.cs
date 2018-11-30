using Nano.N_Base.Model.Entity;
using Nano.N_Gym.App.Model.Enum.Exercicio;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("EXERCICIOS")]
    public class Exercicio : EntityBase
    {
        [Required]
        public string Nome { get; set; }
        public TipoExercicio Tipo { get; set; }
        public string Descricao { get; set; }
    }
}
