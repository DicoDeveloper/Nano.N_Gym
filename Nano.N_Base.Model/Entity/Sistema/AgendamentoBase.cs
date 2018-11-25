using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("AGENDAMENTOS_BASE")]
    public class AgendamentoBase : EntityBaseEmpresa
    {
        [MaxLength(60), Required]
        public string Titulo { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public bool DiaInteiro { get; set; }
        public string Descricao { get; set; }
    }
}
