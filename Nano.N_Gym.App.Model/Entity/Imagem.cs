using Nano.N_Base.Model.Entity;
using Nano.N_Base.Model.Entity.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("IMAGENS")]
    public class Imagem : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }

        public virtual ImagemBase Base { get; set; }
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
