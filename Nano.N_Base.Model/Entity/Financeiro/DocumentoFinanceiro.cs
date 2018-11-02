using Nano.N_Base.Model.Entity.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Financeiro
{
    [Table("DOCUMENTOS_FINANCEIROS")]
    public class DocumentoFinanceiro : EntityBaseEmpresa
    {
        [ForeignKey("Transacao")]
        public long IdTransacao { get; set; }
        [ForeignKey("Pessoa")]
        public long IdPessoa { get; set; }
        [MaxLength(30)]
        public string Numero { get; set; }
        [MaxLength(60)]
        public string Descricao { get; set; }
        [ForeignKey("DespesaReceita")]
        public long IdDespesaReceita { get; set; }
        [Range(0.01, 999999.99)]
        public decimal ValorTotal { get; set; }
        public decimal Saldo { get; set; }
        public decimal? ValorEntrada { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Competencia { get; set; }
        public DateTime? Validade { get; set; }
        public string Observacao { get; set; }
        [ForeignKey("CondicaoPagamento")]
        public long? IdCondicaoPagamento { get; set; }

        public virtual Transacao Transacao { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual DespesaReceita DespesaReceita { get; set; }
        public virtual CondicaoPagamento CondicaoPagamento { get; set; }
        public virtual IList<TituloFinanceiro> Titulos { get; set; }

        public DocumentoFinanceiro()
        {
            Titulos = new List<TituloFinanceiro>();
        }
    }
}
