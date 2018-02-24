using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    [Table("FUNCIONARIOS")]
    public class Funcionario : Pessoa
    {
        #region Propriedades
        [Column("ID_CARGO"), ForeignKey("Cargo")]
        public long IdCargo { get; set; }
        [Column("DAT_ADMISSAO")]
        public DateTime DataAdmissao { get; set; }
        [Column("DAT_DESLIGAMENTO")]
        public DateTime DataDesligamento { get; set; }        
        [Column("FOTO_FUNCIONARIO")]
        public string Foto { get; set; }
        public virtual Cargo Cargo { get; set; }
        #endregion
    }
}
