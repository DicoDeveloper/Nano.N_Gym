using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    public class ContratoModalidade
    {
        #region Propriedades
        public long ModalidadeId { get; set; }
        public long ContratoId { get; set; }
        public virtual Modalidade Modalidade { get; set; }
        public virtual Contrato Contrato { get; set; }
        #endregion
    }
}
