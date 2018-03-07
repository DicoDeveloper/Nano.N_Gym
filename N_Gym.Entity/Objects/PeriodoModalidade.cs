using N_Gym.Entity.Enums.Modalidade;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    public class PeriodoModalidade
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [ForeignKey("Modalidade"), Required]
        public long IdModalidade { get; set; }
        [Required]
        public DiaSemana DiaSemana { get; set; }
        [Required]
        public string HrInicio { get; set; }
        [Required]
        public string HrFim { get; set; }
        public bool Ativo { get; set; }
        public virtual Modalidade Modalidade { get; set; }
        #endregion
    }
}
