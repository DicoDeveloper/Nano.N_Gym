using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("PROFICOES")]
    public class Proficao : EntityBase
    {
        [MaxLength(80)]
        public string Descricao { get; set; }

        public virtual IList<ClienteBase> Clientes { get; set; }

        public Proficao()
        {
            Clientes = new List<ClienteBase>();
        }
    }
}
