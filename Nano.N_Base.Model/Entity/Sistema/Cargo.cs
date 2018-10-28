using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("CARGOS")]
    public class Cargo : EntityBase
    {
        [MaxLength(80)]
        public string Descricao { get; set; }

        public virtual IList<Funcionario> Funcionarios { get; set; }

        public Cargo()
        {
            Funcionarios = new List<Funcionario>();
        }
    }
}
