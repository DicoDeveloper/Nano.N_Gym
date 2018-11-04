using Nano.N_Base.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("TREINOS")]
    public class Treino : EntityBase
    {
        [ForeignKey("Cliente"), Required]
        public long IdCliente { get; set; }
        [ForeignKey("Colaborador"), Required]
        public long IdColaborador { get; set; }
        [MaxLength(3), Required]
        public string Numero { get; set; }
        public DateTime? Criacao { get; set; }
        public DateTime? Vencimento { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Colaborador Colaborador { get; set; }
        public virtual IList<ExercicioTreino> Exercicios { get; set; }

        public Treino()
        {
            Exercicios = new List<ExercicioTreino>();
        }
    }
}
