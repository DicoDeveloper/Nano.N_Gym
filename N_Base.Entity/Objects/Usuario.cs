using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    [Table("USUARIOS")]
    public class Usuario
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID_USUARIO")]
        public long Id { get; set; }
        [ForeignKey("Funcionario"), Column("ID_FUNCIONARIO"), Required(ErrorMessage = "É obrigatório informar funcionario usuario")]
        public long IdFuncionario { get; set; }
        [MaxLength(10, ErrorMessage = "Login não pode ultrapassar 10 caracteres"), Required(ErrorMessage = "Login é obrigatório")]
        [Column("LOGIN")]
        public string Login { get => Login; set => Login = value.Length > 10 ? value.Substring(0, 10) : value; }
        [MaxLength(8, ErrorMessage = "Senha não pode passar de 8 caracteres"), Required(ErrorMessage = "Senha é obrigatório")]
        [Column("SENHA")]
        public string Senha { get => Senha; set => Senha = value.Length > 8 ? value.Substring(0, 8) : value; }
        [Required, Column("ATIVO")]
        public bool Ativo { get; set; }
        [ForeignKey("Permissao"), Column("ID_PERMISSAO")]
        public long IdPermissao { get; set; }
        public virtual PermissaoUsuario Permissao { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        #endregion
    }
}
