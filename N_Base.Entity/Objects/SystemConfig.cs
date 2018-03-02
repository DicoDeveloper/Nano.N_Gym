using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class SystemConfig
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [MaxLength(100)]
        public string Descricao { get => Descricao; set => Descricao = value.Length > 50 ? value.Substring(0, 50) : value; }
        public string ValorCampo { get; set; }
        public string Observacao { get; set; }
        #endregion
    }
}
