using Nano.N_Base.Model.Entity;
using Nano.N_Base.Model.Entity.Sistema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("COLABORADORES")]
    public class Colaborador : Pessoa
    {
        [ForeignKey("Usuario")]
        public long? IdUsuario { get; set; }
        [ForeignKey("Cargo")]
        public long? IdCargo { get; set; }
        public DateTime? DataAdmissao { get; set; }
        public DateTime? DataDesligamento { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual IList<Contrato> Contratos { get; set; }
        public virtual IList<Empresa> Empresas { get; set; }
        public virtual IList<Imagem> Imagens { get; set; }
        public virtual IList<PeriodoTurma> PeriodosModalidades { get; set; }
        public virtual IList<Treino> Treinos { get; set; }        

        public Colaborador()
        {
            Contratos = new List<Contrato>();
            Empresas = new List<Empresa>();
            Imagens = new List<Imagem>();
            PeriodosModalidades = new List<PeriodoTurma>();
            Treinos = new List<Treino>();
        }
    }
}
