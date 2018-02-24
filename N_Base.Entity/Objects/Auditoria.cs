using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using N_Base.Entity.Enums.Auditoria;
using N_Base.Entity.Enums.Data;

namespace N_Base.Entity.Objects
{
    [Table("AUDITORIAS")]
    public class Auditoria
    {
        #region Propriedades
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_AUDITORIA")]
        public long Id { get; set; }
        [Column("TIPO_OPERACAO")]
        public TipoOperacao TipoOperacao { get; set; }
        [Column("OQUE")]
        public string Oque { get => Oque; set => Oque = value.Length > 60 ? value.Substring(0, 60) : value; }
        [Column("QUANDO")]
        public DateTime Quando { get; set; }
        [ForeignKey("Usuario")]
        [Column("ID_USUARIO")]
        public long IdUsuario { get; set; }
        [MaxLength(60)]
        [Column("ONDE")]
        public string Onde { get => Onde; set => Onde = value.Length > 60 ? value.Substring(0, 60) : value; }
        [Column("TABELA")]
        public TabelaBaseDados Tabela { get; set; }
        [Column("OBJETOS_AUDITORIA_JSON")]
        public string ObjetosJson { get; set; }
        public virtual Usuario Usuario { get; set; }
        #endregion
    }
}
