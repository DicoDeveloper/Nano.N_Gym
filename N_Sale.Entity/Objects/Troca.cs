using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Sale.Entity.Objects
{
    public class Troca
    {
        #region Propriedades
        public long Id { get; set; }
        [ForeignKey("Venda"), Required(ErrorMessage = "Venda é obrigatório")]
        public long IdVenda { get; set; }
        public DateTime Data { get; set; }
        public virtual List<ItemTroca> Itens { get; set; }
        public virtual Venda Venda { get; set; }
        #endregion

        public Troca() => Itens = new List<ItemTroca>();
    }
}