using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("CLIENTES_BASE")]
    public class ClienteBase : Pessoa
    {
        [ForeignKey("Responsavel")]
        public long? IdResponsavel { get; set; }
        public string Apelido { get; set; }
        public bool PermissaoExporDados { get; set; }

        public virtual ClienteBase Responsavel { get; set; }
        public virtual IList<ClienteBase> Dependentes { get; set; }
        public virtual IList<Proficao> Proficoes { get; set; }

        public ClienteBase()
        {
            Dependentes = new List<ClienteBase>();
            Proficoes = new List<Proficao>();
        }
    }
}
