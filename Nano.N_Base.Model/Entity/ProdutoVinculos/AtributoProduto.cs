using Nano.N_Base.Model.Entity.Sistema;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.ProdutoVinculos
{
    [Table("ATRIBUTOS_PROUTOS")]
    public class AtributoProduto : EntityBase
    {
        [ForeignKey("Empresa")]
        public long IdEmpresa { get; set; }
        [ForeignKey("Produto")]
        public long IdProduto { get; set; }
        public bool PrecoDiferenciadoLote { get; set; }
        public bool BloqueadoSaida { get; set; }
        public bool BloqueadoEntrada { get; set; }

        public virtual Empresa Empresa { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
