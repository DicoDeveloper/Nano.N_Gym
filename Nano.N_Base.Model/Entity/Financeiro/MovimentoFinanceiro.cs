using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Model.Enum.Financeiro;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Financeiro
{
    [Table("MOVIMENTACOES_FINANCEIRAS")]
    public class MovimentoFinanceiro : EntityBaseEmpresa
    {
        [ForeignKey("Transacao")]
        public long IdTransacao { get; set; }
        public decimal? Valor { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? Multa { get; set; }
        public decimal? Juros { get; set; }
        public DateTime DataMovimento { get; set; }
        public DateTime DataContabil { get; set; }
        public TipoDespesaReceita Tipo { get; set; }

        public virtual Transacao Transacao { get; set; }
    }
}
