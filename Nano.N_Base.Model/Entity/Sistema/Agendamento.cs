using Nano.N_Base.Model.Enum.Auditoria;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("AGENDAMENTOS")]
    public class Agendamento : EntityBaseEmpresa
    {
        [MaxLength(60)]
        public string Titulo { get; set; }
        [MaxLength(80)]
        public string Local { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public bool DiaInteiro { get; set; }
        public string Descricao { get; set; }
    }
}
