using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("CONTATOS")]
    public class Contato : EntityBase
    {
        [ForeignKey("Pessoa")]
        public long IdPessoa { get; set; }
        [MaxLength(50)]
        public string Descricao { get; set; }
        [MaxLength(100)]
        public string EmailPrincipal { get; set; }
        [MaxLength(16)]
        public string TelefonePrincipal { get; set; }
        public string EmailsJson { get; set; }
        public string TelefonesJson { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
