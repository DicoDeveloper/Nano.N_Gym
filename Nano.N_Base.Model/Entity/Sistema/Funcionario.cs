using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("FUNCIONARIOS")]
    public class Funcionario : Pessoa
    {
        [ForeignKey("Cargo")]
        public long? IdCargo { get; set; }
        public DateTime? DataAdmissao { get; set; }
        public DateTime? DataDesligamento { get; set; }

        public virtual Cargo Cargo { get; set; }
        public virtual IList<Empresa> Empresas { get; set; }

        public Funcionario()
        {
            Empresas = new List<Empresa>();
        }
    }
}
