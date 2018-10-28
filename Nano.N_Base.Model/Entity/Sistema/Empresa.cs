using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("EMPRESAS")]
    public class Empresa : Pessoa
    {
        [MaxLength(80)]
        public string NomeFantasia { get; set; }
    }
}
