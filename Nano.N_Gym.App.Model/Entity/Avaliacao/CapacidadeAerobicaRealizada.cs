using Nano.N_Base.Model.Entity;
using Nano.N_Gym.App.Model.Enum.Avaliacao;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("CAPACIDADES_AEROBICAS_REALIZADAS")]
    public class CapacidadeAerobicaRealizada : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        public ProtocoloVo2MaxRealizado Protocolo { get; set; }
        public decimal? Tempo { get; set; }
        public decimal? FrequenciaCardiacaFinal { get; set; }
        public string PressaoArterialFinal { get; set; }
        public decimal? MetrosDistancia { get; set; }
        public decimal Vo2Max { get; set; }

        public virtual AvaliacaoBase Base { get; set; }
    }
}
