using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    public class Treino
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [ForeignKey("Cliente"), Required]
        public long IdCliente { get; set; }
        [MaxLength(3), Required]
        public string Numero { get; set; }
        public DateTime DataCriacao { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual List<ExercicioTreino> ExerciciosTreino { get; set; }
        #endregion
    }
}
