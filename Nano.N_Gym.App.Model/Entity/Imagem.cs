using Nano.N_Base.Model.Entity.Sistema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("IMAGENS")]
    public class Imagem : ImagemBase
    {
        public virtual IList<Aparelho> Aparelhos { get; set; }
        public virtual IList<Cliente> Clientes { get; set; }
        public virtual IList<Colaborador> Colaboradores { get; set; }
        public virtual IList<Localizacao> Localizacoes { get; set; }

        public Imagem()
        {
            Aparelhos = new List<Aparelho>();
            Clientes = new List<Cliente>();
            Colaboradores = new List<Colaborador>();
            Localizacoes = new List<Localizacao>();
        }
    }
}
