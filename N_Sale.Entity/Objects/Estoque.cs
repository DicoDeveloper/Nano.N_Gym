using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Sale.Entity.Objects
{
    public class Estoque
    {
        #region Propriedades
        public long Id { get; set; }
        [ForeignKey("Produto")]
        public long IdProduto {get;set;}
        [Range(0, 999999.999, ErrorMessage = "Quantidade minima não pode ser negativa")]
        public int QtdMinima { get; set; }
        [Range(0, 999999.999, ErrorMessage = "Quantidade maxima não pode ser negativa")]
        public int QtdMaxima { get; set; }
        [Range(-999999.99, 999999.999)]
        public decimal QtdEstoque { get; set; }
        public virtual Produto Produto {get;set;}
        #endregion
    }
}