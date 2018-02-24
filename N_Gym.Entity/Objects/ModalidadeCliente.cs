using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("MODALIDADES_CLIENTES")]
    public class ModalidadeCliente
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID_MODALIDADES_CLIENTES")]
        public long Id { get; set; }
        [Column("ID_MODALIDADE"), ForeignKey("Modalidade")]
        public long IdModalidade { get; set; }
        [Column("ID_CLIENTE"), ForeignKey("Cliente")]
        public long IdCiente { get; set; }
        [Column("DAT_VALIDADE")]
        public DateTime DataValidade { get; set; }
        [Column("VAL_MODALIDADE"), Required, Range(0.01, 999999.99)]
        public decimal ValorModalidade { get; set; }
        [Column("VAL_DESCONTO"), Range(0, 999999.99)]
        public decimal ValorDesconto { get; set; }
        public virtual ICollection<PagamentoModalidadeCliente> PagamentoModalidadeCliente { get; set; }
        public virtual Modalidade Modalidade { get; set; }
        public virtual ClienteGym Cliente { get; set; }
        #endregion
    }
}
