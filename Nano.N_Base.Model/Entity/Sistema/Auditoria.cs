using Nano.N_Base.Model.Enum.Auditoria;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("AUDITORIAS")]
    public class Auditoria : EntityBasePorEmpresa
    {
        public TipoOperacao TipoOperacao { get; set; }
        [MaxLength(50)]
        public string Oque { get; set; }
        public DateTime Quando { get; set; }
        [MaxLength(100)]
        public string NomeUsuario { get; set; }
        [MaxLength(60)]
        public string Onde { get; set; }
        public Type Entidade { get; set; }
        public string ObjetosJson { get; set; }
    }
}
