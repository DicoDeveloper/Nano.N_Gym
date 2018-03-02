using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class Cargo
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required(ErrorMessage = "Código é obrigatório")]
        public long Codigo { get; set; }
        [MaxLength(40, ErrorMessage = "Descrição não pode ultrapassar 40 caracteres")]
        public string Descricao { get => Descricao; set => Descricao = value.Length > 40 ? value.Substring(0, 40) : value; }
        [MaxLength(40, ErrorMessage = "Setor não pode ultrapassar 40 caracteres")]
        public string Setor { get => Setor; set => Setor = value.Length > 40 ? value.Substring(0, 40) : value; }
        #endregion
    }
}
