using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Model.Enum.Financeiro;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Financeiro
{
    [Table("TITULOS_FINANCEIROS")]
    public class TituloFinanceiro : EntityBaseEmpresa
    {
        [ForeignKey("Transacao")]
        public long IdTransacao { get; set; }
        [ForeignKey("DocumentoFinanceiro")]
        public long IdDocumentoFinanceiro { get; set; }        
        [Range(1, 999)]
        public int Numero { get; set; }
        [Range(0.01, 999999.99)]
        public decimal ValorTotal { get; set; }
        public decimal Saldo { get; set; }
        public decimal? Desconto { get; set; }
        public decimal? Multa { get; set; }
        public decimal? Juros { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Pagamento { get; set; }
        public TipoSituacaoTitulo Situacao { get; set; }

        public virtual DocumentoFinanceiro DocumentoFinanceiro { get; set; }
        public virtual Transacao Transacao { get; set; }
    }
}
