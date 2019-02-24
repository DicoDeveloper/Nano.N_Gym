using Nano.N_Base.Model.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("TURMAS")]
    public class Turma : EntityBaseEmpresa
    {
        [ForeignKey("Modalidade"), Required]
        public long IdModalidade { get; set; }
        [MaxLength(60), Required]
        public string Nome { get; set; }
        public int? LimiteMaximo { get; set; }

        public virtual Modalidade Modalidade { get; set; }
        public virtual IList<Cliente> Clientes { get; set; }
        public virtual IList<Colaborador> Colaboradores { get; set; }

        public Turma()
        {
            Clientes = new List<Cliente>();
            Colaboradores = new List<Colaborador>();
        }
    }
}
