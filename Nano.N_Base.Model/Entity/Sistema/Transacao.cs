using Nano.N_Base.Model.Entity.Estoque;
using Nano.N_Base.Model.Entity.Financeiro;
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
        public virtual IList<MovimentacaoEstoque> Movimentacoes { get; set; }
        public virtual IList<TituloFinanceiro> TitulosFinanceiros { get; set; }

        public Transacao()
        {
            DocumentosFinanceiros = new List<DocumentoFinanceiro>();
            Movimentacoes = new List<MovimentacaoEstoque>();
            TitulosFinanceiros = new List<TituloFinanceiro>();
        }
    }
}
