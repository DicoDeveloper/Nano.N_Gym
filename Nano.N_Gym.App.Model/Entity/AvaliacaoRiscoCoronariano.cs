using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("AVALIACOES_RISCOS_CORONARIANOS")]
    public class AvaliacaoRiscoCoronariano : EntityBase
    {
        [ForeignKey("IMC")]
        public long IdIMC { get; set; }
        public int AbdomePerimetria { get; set; }
        [MaxLength(40)]
        public string Resultado { get; set; }

        public virtual AvaliacaoIMC IMC { get; set; }
    }
}
