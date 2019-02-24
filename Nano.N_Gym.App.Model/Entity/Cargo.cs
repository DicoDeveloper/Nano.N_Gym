using Nano.N_Base.Model.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("CARGOS")]
    public class Cargo : EntityBase
    {
        [MaxLength(80), Required]
        public string Descricao { get; set; }

        public virtual IList<Colaborador> Funcionarios { get; set; }

        public Cargo()
        {
            Funcionarios = new List<Colaborador>();
        }
    }
}
