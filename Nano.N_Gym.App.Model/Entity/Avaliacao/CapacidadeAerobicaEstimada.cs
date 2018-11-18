using Nano.N_Base.Model.Entity;
using Nano.N_Gym.App.Model.Enum.Avaliacao;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("CAPACIDADES_AEROBICAS_ESTIMADAS")]
    public class CapacidadeAerobicaEstimada : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        public ProtocoloVo2MaxEstimado Protocolo { get; set; }
        public NivelAtividadeAerobica NivelAtividade { get; set; }
        public decimal Vo2Max { get; set; }

        public virtual AvaliacaoBase Base { get; set; }
    }
}
