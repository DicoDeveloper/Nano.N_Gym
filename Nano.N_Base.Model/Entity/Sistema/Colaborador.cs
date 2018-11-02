using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("COLABORADORES")]
    public class Colaborador : Pessoa
    {
        [ForeignKey("Usuario")]
        public long? IdUsuario { get; set; }
        [ForeignKey("Cargo")]
        public long? IdCargo { get; set; }
        public DateTime? DataAdmissao { get; set; }
        public DateTime? DataDesligamento { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual IList<Empresa> Empresas { get; set; }

        public Colaborador()
        {
            Empresas = new List<Empresa>();
        }
    }
}
