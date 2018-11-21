using Nano.N_Base.Model.Entity.Financeiro;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Model.Enum.Fiscal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Fiscal
{
    [Table("DOCUMENTOS_FISCAIS")]
    public class DocumentoFiscal : EntityBaseEmpresa
    {
        [ForeignKey("Transaco")]
        public long IdTransacao { get; set; }
        public TipoAplicacao Aplicacao { get; set; }
        [ForeignKey("OperacaoFiscal")]
        public long IdOperacao { get; set; }
        [ForeignKey("Serie")]
        public long IdSerie { get; set; }
        [Range(1, 9999)]
        public int Numero { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime DataHoraExpedicao { get; set; }
        public DateTime DataContabil { get; set; }
        [ForeignKey("Vendedor")]
        public long? IdVendedor { get; set; }
        [ForeignKey("DestinatarioEmitente")]
        public long? IdDestinatarioEmitente { get; set; }
        [ForeignKey("Endereco")]
        public long? IdEndereco { get; set; }
        [MaxLength(50)]
        public string ChaveFiscal { get; set; }
        [MaxLength(8)]
        public string ComposicaoChave { get; set; }
        public decimal? PesoLiquido { get; set; }
        public decimal? PesoBruto { get; set; }
        public decimal? Frete { get; set; }
        public decimal? Seguro { get; set; }
        public decimal? Embalagem { get; set; }
        public decimal? DespesasAcessorias { get; set; }
        public decimal? Desconto { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal TotalLiquido { get; set; }
        public string Observacoes { get; set; }
        [ForeignKey("CondicaoPagamento")]
        public long? IdCondicaoPagamento { get; set; }

        public virtual Pessoa Vendedor { get; set; }
        public virtual CondicaoPagamento CondicaoPagamento { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual OperacaoFiscal OperacaoFiscal { get; set; }
        public virtual Pessoa DestinatarioEmitente { get; set; }
        public virtual SerieFiscal Serie { get; set; }
        public virtual Transacao Transaco { get; set; }
        public virtual IList<ItemDocumentoFiscal> itens { get; set; }

        public DocumentoFiscal()
        {
            itens = new List<ItemDocumentoFiscal>();
        }
    }
}
