using Nano.N_Base.Model.Entity;
using Nano.N_Gym.App.Model.Enum.Avaliacao;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("FLEXIBILIDADES")]
    public class Flexibilidade : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        public decimal AlcanceSentado { get; set; }
        public TipoFlexaoExtensao FlexaoTornozeloDorsal { get; set; }
        public TipoFlexaoExtensao FlexaoTornozeloPlantar { get; set; }
        public TipoFlexaoExtensao FlexaoJoelho { get; set; }
        public TipoFlexaoExtensao ExtensaoJoelho { get; set; }
        public TipoFlexaoExtensao FlexaoQuadril { get; set; }
        public TipoFlexaoExtensao ExtensaoQuadril { get; set; }
        public TipoFlexaoExtensao AducaoQuadril { get; set; }
        public TipoFlexaoExtensao AbducaoQuadril { get; set; }
        public TipoFlexaoExtensao FlexaoTRonco { get; set; }
        public TipoFlexaoExtensao FlexaoLateralTRonco { get; set; }
        public TipoFlexaoExtensao ExtensaoTRonco { get; set; }
        public TipoFlexaoExtensao FlexaoPunho { get; set; }
        public TipoFlexaoExtensao ExtensaoPunho { get; set; }
        public TipoFlexaoExtensao FlexaoCotovelo { get; set; }
        public TipoFlexaoExtensao ExtensaoCotovelo { get; set; }
        public TipoFlexaoExtensao AducaoPosteriorOmbro { get; set; }
        public TipoFlexaoExtensao ExtensaoOmbro { get; set; }
        public TipoFlexaoExtensao ExtensaoPosteriorOmbro { get; set; }
        public TipoFlexaoExtensao RotacaoLateralOmbro { get; set; }
        public TipoFlexaoExtensao RotacaoMedialOmbro { get; set; }

        public virtual AvaliacaoBase Base { get; set; }
    }
}
