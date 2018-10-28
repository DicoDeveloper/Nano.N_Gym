using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("USUARIOS")]
    public class Usuario : EntityBase
    {
        [MaxLength(80), Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }
        [MaxLength(15), Required(ErrorMessage = "Senha é obrigatório")]
        public string Senha { get; set; }
        [ForeignKey("Permissao")]
        public long IdPermissao { get; set; }

        public virtual PermissaoUsuario Permissao { get; set; }
        public virtual IList<Empresa> EmpresasAcesso { get; set; }

        public Usuario()
        {
            EmpresasAcesso = new List<Empresa>();
        }
    }
}
