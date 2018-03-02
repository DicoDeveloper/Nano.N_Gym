using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class Cliente : Pessoa
    {
        #region Propriedades
        public string Foto { get; set; }
        #endregion
    }
}
