using Nano.N_Base.Model.Entity;
using Nano.N_Base.Model.Entity.Sistema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("AGENDAMENTOS")]
    public class Agendamento : EntityBaseEmpresa
    {        
        [ForeignKey("Base")]
        public long IdBase { get; set; }        
        [ForeignKey("Endereco")]
        public long? IdEndereco { get; set; }
        [ForeignKey("Localizacao")]
        public long? IdLocalizacao { get; set; }
        [ForeignKey("Modalidade")]
        public long? IdModalidade { get; set; }
        [ForeignKey("Usuario")]
        public long? IdUsuario { get; set; }

        public virtual AgendamentoBase Base { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Localizacao Localizacao { get; set; }
        public virtual Modalidade Modalidade { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual IList<Cliente> Clientes { get; set; }
        public virtual IList<Colaborador> Colaboradores { get; set; }
        public virtual IList<Contato> Contatos { get; set; }

        public Agendamento()
        {
            Clientes = new List<Cliente>();
            Colaboradores = new List<Colaborador>();
            Contatos = new List<Contato>();
        }
    }
}
