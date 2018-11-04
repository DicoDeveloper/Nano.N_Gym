using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("COLABORADORES_BASE")]
    public class ColaboradorBase : Pessoa
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

        public ColaboradorBase()
        {
            Empresas = new List<Empresa>();
        }
    }
}
