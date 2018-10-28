using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("CARACTERISTICAS")]
    public class Caracteristica : EntityBase
    {
        [MaxLength(80)]
        public string Descricao { get; set; }
        [ForeignKey("Pai")]
        public long? IdPai { get; set; }

        public virtual Caracteristica Pai { get; set; }
        public virtual IList<Pessoa> Pessoas { get; set; }

        public Caracteristica()
        {
            Pessoas = new List<Pessoa>();
        }
    }
}
