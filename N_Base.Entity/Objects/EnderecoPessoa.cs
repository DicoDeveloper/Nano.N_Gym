using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class EnderecoPessoa
    {
        public long EnderecoId { get; set; }
        public long PessoaId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
