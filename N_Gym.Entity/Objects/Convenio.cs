using System.Collections.Generic;
using N_Gym.Entity.Enums;

namespace N_Gym.Entity.Objects
{
    public class Convenio
    {
        #region Propriedades
        public long Id { get; set; }
        public long Codigo { get; set; }
        public string Descricao { get; set; }
        public ModoCobranca Modo { get; set; }
        public decimal Desconto { get; set; }
        public bool Ativo { get; set; }
        public virtual List<ConvenioCliente> ConveniosCliente { get; set; }
        #endregion
    }
}