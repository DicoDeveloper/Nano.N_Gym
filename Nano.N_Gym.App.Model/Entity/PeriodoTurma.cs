using Nano.N_Base.Model.Entity;
using Nano.N_Gym.App.Model.Enum.Modalidade;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("PERIODOS_TURMAS")]
    public class PeriodoTurma : EntityBaseEmpresa
    {
        [ForeignKey("Turma"), Required]
        public long IdTurma { get; set; }
        [ForeignKey("Localizacao"), Required]
        public long IdLocalizacao { get; set; }
        public DiaSemana DiaSemana { get; set; }
        [Required]
        public string HrInicio { get; set; }
        [Required]
        public string HrFim { get; set; }

        public virtual Turma Turma { get; set; }
        public virtual Localizacao Localizacao { get; set; }
    }
}
