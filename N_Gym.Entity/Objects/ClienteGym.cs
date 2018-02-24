using N_Base.Entity.Objects;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("CLIENTES_ACADEMY")]
    public class ClienteGym : Cliente
    {
        #region Propriedades
        [MaxLength(30, ErrorMessage = "CR não pode ultrapassar 30 caracteres"), Column("CR")]
        public string CR { get; set; }
        [Column("CONTROLE_MODALIDADE")]
        public string ControleModalidade { get; set; }
        [Column("ACESSO_LIVRE")]
        public bool AcessoLivre { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; }
        public virtual ICollection<Treino> Treinos { get; set; }
        public virtual ICollection<ModalidadeCliente> Modalidades { get; set; }
        #endregion
    }
}
