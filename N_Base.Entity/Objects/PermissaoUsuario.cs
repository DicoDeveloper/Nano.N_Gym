using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    [Table("PERMISSOES_USUARIOS")]
    public class PermissaoUsuario
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID_PERMISSAO")]
        public long Id { get; set; }
        #endregion
    }
}
