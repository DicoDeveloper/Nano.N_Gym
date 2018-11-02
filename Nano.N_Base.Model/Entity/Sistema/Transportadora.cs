using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("TRANSPORTADORAS")]
    public class Transportadora : Pessoa
    {        
        public string Observacoes { get; set; }
    }
}
