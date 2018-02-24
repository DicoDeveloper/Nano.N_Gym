using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("TREINOS")]
    public class Treino
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID_TREINO")]
        public long Id { get; set; }
        [ForeignKey("Cliente"), Required, Column("ID_CLIENTE")]
        public long IdCliente { get; set; }
        [MaxLength(3), Column("NUMERO_TREINO"), Required]
        public string Numero { get; set; }
        [Column("DAT_CRIACAO")]
        public DateTime DataCriacao { get; set; }
        public virtual ClienteGym Cliente { get; set; }
        public virtual ICollection<ExercicioTreino> Exercicios { get; set; }
        #endregion
    }
}
