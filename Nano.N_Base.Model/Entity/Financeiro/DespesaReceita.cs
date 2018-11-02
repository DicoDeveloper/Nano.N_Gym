using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Model.Enum.Financeiro;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Financeiro
{
    [Table("DESPESAS_RECEITAS")]
    public class DespesaReceita : EntityBase
    {
        [MaxLength(100)]
        public string Descricao { get; set; }
        public TipoDespesaReceita Tipo { get; set; }
        public TipoMovimentacaoFinanceira TipoMovimentacao { get; set; }
        public TipoCompetenciaSugerida CompetenciaSugerida { get; set; }
        public decimal? PercentualMulta { get; set; }
        public int? DiasCarenciaMulta { get; set; }
        public decimal? PercentualJurosMensal { get; set; }
        public int? DiasCarenciaJuros { get; set; }
        public decimal? PercentualDesconto { get; set; }
        public int? DiasCarenciaDesconto { get; set; }
        public string Observacoes { get; set; }

        public virtual IList<Empresa> Empresas { get; set; }

        public DespesaReceita()
        {
            Empresas = new List<Empresa>();
        }
    }
}
