using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class Funcionario : Pessoa
    {
        #region Propriedades
        [ForeignKey("Cargo")]
        public long IdCargo { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }
        public string Foto { get; set; }
        public virtual Cargo Cargo { get; set; }
        #endregion
    }
}
