using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Sale.Entity.Objects
{
    public class Compra : MovimentoMercadoria
    {
        #region Propriedades
        [ForeignKey("Fornecedor")]
        [Required(ErrorMessage = "É obrigatório informar um fornecedor")]
        public long IdFornecedor { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual List<ContaPagarCompra> ContasPagar { get; set; }
        #endregion
    }
}