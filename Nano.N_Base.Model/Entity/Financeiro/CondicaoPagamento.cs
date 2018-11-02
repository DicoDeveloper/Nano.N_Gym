using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Model.Enum.Financeiro;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Financeiro
{
    [Table("CONDICOES_PAGAMENTOS")]
    public class CondicaoPagamento : EntityBase
    {
        [Range(1, 9999)]
        public int Codigo { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }
        public TipoContaMeioPagamento TipoConta { get; set; }
        [Required]
        public string Condicao { get; set; }
        public bool ConsiderarSomenteDiasUteis { get; set; }
        public TipoAlteracaoCondicaoPagamento TipoAlteracao { get; set; }
        public bool TaxaFinanciamento { get; set; }
        public decimal? PercentualAcrescimo { get; set; }
        public TipoTaxaFinanciamento TipoTaxa { get; set; }

        public virtual MeioPagamento MeioPagamentoTroco { get; set; }
        public virtual IList<Empresa> Empresas { get; set; }

        public CondicaoPagamento()
        {
            Empresas = new List<Empresa>();
        }
    }
}
