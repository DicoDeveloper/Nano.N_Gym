using Nano.N_Base.Model.Entity.Sistema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("CLIENTES")]
    public class Cliente : Pessoa
    {
        public string Apelido {get;set;}
        public bool AcessoLivre { get; set; }
        public string Foto { get; set; }
        public bool PermissaoExporDados { get; set; }

        public virtual IList<Avaliacao> Avaliacoes { get; set; }
        public virtual IList<Treino> Treinos { get; set; }
        public virtual IList<Cliente> Dependentes { get; set; }
        public virtual IList<Contrato> Contratos { get; set; }

        public Cliente()
        {
            Avaliacoes = new List<Avaliacao>();
            Treinos = new List<Treino>();
            Dependentes = new List<Cliente>();
            Contratos = new List<Contrato>();
        }
    }
}
