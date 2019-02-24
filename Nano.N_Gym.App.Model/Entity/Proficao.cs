using Nano.N_Base.Model.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("PROFICOES")]
    public class Proficao : EntityBase
    {
        [MaxLength(80), Required]
        public string Descricao { get; set; }

        public virtual IList<Cliente> Clientes { get; set; }

        public Proficao()
        {
            Clientes = new List<Cliente>();
        }
    }
}
