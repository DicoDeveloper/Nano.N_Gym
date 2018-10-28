using Nano.N_Base.Model.Enum.Endereco;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("ENDERECOS")]
    public class Endereco : EntityBase
    {
        [MaxLength(9)]
        public string CEP { get; set; }
        [MaxLength(60)]
        public string Rua { get; set; }
        [MaxLength(15)]
        public string Numero { get; set; }
        [MaxLength(60)]
        public string Complemento { get; set; }
        [MaxLength(60)]
        public string Cidade { get; set; }
        public UF UF { get; set; }        
        public bool Principal { get; set; }       
    }
}
