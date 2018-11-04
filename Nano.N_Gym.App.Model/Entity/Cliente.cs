using Nano.N_Base.Model.Entity;
using Nano.N_Base.Model.Entity.Sistema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("CLIENTES")]
    public class Cliente : EntityBase
    {
        [ForeignKey("ClienteBase")]
        public long IdClienteBase { get; set; }
        public bool AcessoLivre { get; set; }

        public virtual ClienteBase ClienteBase { get; set; }
        public virtual IList<AvaliacaoBase> Avaliacoes { get; set; }
        public virtual IList<Treino> Treinos { get; set; }
        public virtual IList<Contrato> Contratos { get; set; }
        

        public Cliente()
        {
            Avaliacoes = new List<AvaliacaoBase>();
            Treinos = new List<Treino>();
            Contratos = new List<Contrato>();
        }
    }
}
