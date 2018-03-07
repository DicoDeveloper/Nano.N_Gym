using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using N_Base.Entity.Enums.Auditoria;
using N_Base.Entity.Enums.Data;
using N_Base.Entity.Interfaces;

namespace N_Base.Entity.Objects
{
    public class Auditoria
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public TipoOperacao TipoOperacao { get; set; }
        public string Oque { get => Oque; set => Oque = value.Length > 60 ? value.Substring(0, 60) : value; }
        public DateTime Quando { get; set; }
        [ForeignKey("Usuario")]
        public long IdUsuario { get; set; }
        [MaxLength(60)]
        public string Onde { get => Onde; set => Onde = value.Length > 60 ? value.Substring(0, 60) : value; }
        public TabelaBaseDados Tabela { get; set; }
        public string ObjetosJson { get; set; }
        public virtual Usuario Usuario { get; set; }
        #endregion
    }
}
