using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("RISCOS_CORONARIANOS")]
    public class RiscoCoronariano : EntityBase
    {
        [ForeignKey("IMC")]
        public long IdIMC { get; set; }
        public decimal AbdomePerimetria { get; set; }
        [MaxLength(40)]
        public string Resultado { get; set; }

        public virtual IMC IMC { get; set; }
    }
}
