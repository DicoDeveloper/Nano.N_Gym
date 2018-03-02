using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class EnderecoPessoa
    {
        public int EnderecoId { get; set; }
        public int PessoaId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
