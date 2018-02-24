using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    [Table("SYSTEM_CONFIGS")]
    public class SystemConfig
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID_SYSTEM_CONFIG")]
        public long Id { get; set; }
        [MaxLength(100), Column("DESCRICAO")]
        public string Descricao { get => Descricao; set => Descricao = value.Length > 50 ? value.Substring(0, 50) : value; }
        [Column("VAL_CAMPO")]
        public string ValorCampo { get; set; }
        [Column("OBSERVACAO")]
        public string Observacao { get; set; }
        #endregion
    }
}
