using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    [Table("CLIENTES")]
    public class Cliente : Pessoa
    {
        #region Propriedades
        [Column("FOTO_CLIENTE")]
        public string Foto { get; set; }
        #endregion
    }
}
