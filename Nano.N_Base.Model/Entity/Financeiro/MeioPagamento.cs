using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Model.Enum.Financeiro;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Financeiro
{
    [Table("MEIOS_PAGAMENTOS")]
    public class MeioPagamento : EntityBase
    {
        [Range(1, 9999)]
        public int Codigo { get; set; }
        [MaxLength(100)]
        public string Descricao { get; set; }
        public TipoMeioPagamento Tipo { get; set; }
        public TipoContaMeioPagamento TipoConta { get; set; }
        public decimal? ValorMaximo { get; set; }
        public decimal? PercentualAcrescimo { get; set; }
        public decimal? PercentualDesconto { get; set; }
        public bool PermiteTroco { get; set; }
        public decimal? ValorMaximoTroco { get; set; }
        [ForeignKey("MeioPagamentoTroco")]
        public long? IdMeioPagamentoTroco { get; set; }

        public virtual MeioPagamento MeioPagamentoTroco { get; set; }
        public virtual IList<Empresa> Empresas { get; set; }

        public MeioPagamento()
        {
            Empresas = new List<Empresa>();
        }
    }
}
