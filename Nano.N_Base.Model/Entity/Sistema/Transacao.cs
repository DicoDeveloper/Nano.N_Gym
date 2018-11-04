using Nano.N_Base.Model.Entity.Estoque;
using Nano.N_Base.Model.Entity.Financeiro;
using Nano.N_Base.Model.Entity.Fiscal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("TRANSACOES")]
    public class Transacao : EntityBase
    {
        [MaxLength(5)]
        public string Codigo { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }

        public virtual IList<DocumentoFinanceiro> DocumentosFinanceiros { get; set; }
        public virtual IList<DocumentoFiscal> DocumentosFiscais { get; set; }
        public virtual IList<MovimentoEstoque> MovimentosEstoque { get; set; }
        public virtual IList<MovimentoFinanceiro> MovimentosFinanceiro { get; set; }
        public virtual IList<TituloFinanceiro> TitulosFinanceiros { get; set; }

        public Transacao()
        {
            DocumentosFinanceiros = new List<DocumentoFinanceiro>();
            DocumentosFiscais = new List<DocumentoFiscal>();
            MovimentosEstoque = new List<MovimentoEstoque>();
            MovimentosFinanceiro = new List<MovimentoFinanceiro>();
            TitulosFinanceiros = new List<TituloFinanceiro>();
        }
    }
}
