using N_Gym.Entity.Enums.Modalidade;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("PERIODOS_MODALIDADES")]
    public class PeriodoModalidade
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID_PERIODO_MODALIDADE")]
        public long Id { get; set; }
        [ForeignKey("Modalidade"), Column("ID_MODALIDADE"), Required]
        public long IdModalidade { get; set; }
        [Column("DIA_SEMANA"), Required]
        public DiaSemana DiaSemana { get; set; }
        [Column("HR_INICIO"), Required]
        public string HrInicio { get; set; }
        [Column("HR_FIM"), Required]
        public string HrFim { get; set; }
        public virtual Modalidade Modalidade { get; set; }
        #endregion
    }
}
