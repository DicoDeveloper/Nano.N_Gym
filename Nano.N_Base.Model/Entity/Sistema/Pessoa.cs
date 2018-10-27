using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("PESSOAS")]
    public class Pessoa : EntityBase
    {
        public string Nome { get; set; }
    }
}
