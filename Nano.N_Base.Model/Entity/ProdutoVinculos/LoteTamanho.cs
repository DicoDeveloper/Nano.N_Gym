using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.ProdutoVinculos
{
    [Table("LOTES_TAMANHOS")]
    public class LoteTamanho : EntityBase
    {
        [MaxLength(20)]
        public string Descricao { get; set; }
    }
}
