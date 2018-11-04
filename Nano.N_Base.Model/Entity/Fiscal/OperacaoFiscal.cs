using Nano.N_Base.Model.Entity.Financeiro;
using Nano.N_Base.Model.Enum.Fiscal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Fiscal
{
    [Table("OPERACOES_FISCAIS")]
    public class OperacaoFiscal : EntityBase
    {
        [Range(1, 999)]
        public int Codigo { get; set; }
        [MaxLength(50)]
        public string Descricao { get; set; }
        public TipoOperacaoFsical TipoOperacao { get; set; }
        public TipoAplicacao Aplicacao { get; set; }
        public IndicadorPresenca IndicadorPresenca { get; set; }
        [ForeignKey("Serie")]
        public long IdSerie { get; set; }
        public bool AlteraSerie { get; set; }
        [ForeignKey("DespesaReceita")]
        public long IdDespesaReceita { get; set; }
        public bool AtualizaFinanceiro { get; set; }
        public bool AtualizaEstoque { get; set; }
        public bool DestinatarioObrigatorio { get; set; }
        public bool PermiteAlteracaoValorTributo { get; set; }

        public virtual DespesaReceita DespesaReceita { get; set; }
        public virtual SerieFiscal Serie { get; set; }
    }
}
