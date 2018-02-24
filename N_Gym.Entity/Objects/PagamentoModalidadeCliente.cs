using N_Base.Entity.Objects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("PAGAMENTOS_MODALIDADES_CLIENTES")]
    public class PagamentoModalidadeCliente : Pagamento
    {
        #region        
        [Column("ID_MODALIDADE_CLIENTE"), Required, ForeignKey("ModalidadeCliente")]
        public long IdModalidadeCliente { get; set; }
        public virtual ModalidadeCliente ModalidadeCliente { get; set; }
        #endregion
    }
}
