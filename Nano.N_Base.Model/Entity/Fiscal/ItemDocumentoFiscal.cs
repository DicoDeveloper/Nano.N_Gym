using Nano.N_Base.Model.Entity.ProdutoVinculos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Fiscal
{
    [Table("ITENS_DOCUMENTOS_FISCAIS")]
    public class ItemDocumentoFiscal : EntityBaseEmpresa
    {
        [ForeignKey("Documento")]
        public long IdDocumento { get; set; }
        [ForeignKey("Produto")]
        public long IdProduto { get; set; }
        [ForeignKey("UnidadeMedida")]
        public long IdUnidadeMedida { get; set; }
        [ForeignKey("Lote")]
        public long? IdLote { get; set; }
        [Range(0.001, 999999.999)]
        public decimal Quantidade { get; set; }
        [Range(0.00, 999999.99)]
        public decimal ValorUnitario { get; set; }
        public decimal? DescontoUnitario { get; set; }
        [Range(0.00, 999999.99)]
        public decimal TotalBruto { get; set; }
        [Range(0.00, 999999.99)]
        public decimal TotalLiquido { get; set; }

        public virtual DocumentoFiscal Documento { get; set; }
        public virtual LoteCorTamanho Lote { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
    }
}
