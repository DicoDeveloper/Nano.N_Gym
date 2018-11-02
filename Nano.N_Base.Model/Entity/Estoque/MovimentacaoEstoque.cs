using Nano.N_Base.Model.Entity.ProdutoVinculos;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Model.Enum.Movimentacao;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Estoque
{
    [Table("MOVIMENTACOES_ESTOQUES")]
    public class MovimentacaoEstoque : EntityBaseEmpresa
    {
        [ForeignKey("Produto")]
        public long IdProduto { get; set; }
        [ForeignKey("Lote")]
        public long? IdLote { get; set; }
        [ForeignKey("Transacao")]
        public long IdTransacao { get; set; }
        public TipoMovimentacao Tipo { get; set; }
        public decimal Quantidade { get; set; }
        public decimal? PrecoVenda { get; set; }
        public decimal? PrecoCusto { get; set; }
        public decimal? PrecoMedio { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataHoraContabil { get; set; }

        public virtual Produto Produto { get; set; }
        public virtual LoteCorTamanho Lote { get; set; }
        public virtual Transacao Transacao { get; set; }
    }
}
