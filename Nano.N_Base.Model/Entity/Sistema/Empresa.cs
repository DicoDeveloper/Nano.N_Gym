using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("EMPRESAS")]
    public class Empresa : Pessoa
    {
        public string CNPJ { get; set; }

        public override string ToString()
        {
            return "EMPRESAS";
        }
    }
}
