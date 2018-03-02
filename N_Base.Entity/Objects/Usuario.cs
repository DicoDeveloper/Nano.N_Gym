using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class Usuario
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [ForeignKey("Funcionario"), Required(ErrorMessage = "É obrigatório informar funcionario usuario")]
        public long IdFuncionario { get; set; }
        [MaxLength(10, ErrorMessage = "Login não pode ultrapassar 10 caracteres"), Required(ErrorMessage = "Login é obrigatório")]
        public string Login { get => Login; set => Login = value.Length > 10 ? value.Substring(0, 10) : value; }
        [MaxLength(8, ErrorMessage = "Senha não pode passar de 8 caracteres"), Required(ErrorMessage = "Senha é obrigatório")]
        public string Senha { get => Senha; set => Senha = value.Length > 8 ? value.Substring(0, 8) : value; }
        [Required]
        public bool Ativo { get; set; }
        [ForeignKey("Permissao")]
        public long IdPermissao { get; set; }
        public virtual PermissaoUsuario Permissao { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        #endregion
    }
}
