using Nano.N_Base.Model.Entity;
using Nano.N_Base.Model.Entity.Sistema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("COLABORADORES")]
    public class Colaborador : EntityBase
    {
        [ForeignKey("ColaboradorBase")]
        public long IdColaboradorBase { get; set; }

        public virtual ColaboradorBase ColaboradorBase { get; set; }
        public virtual IList<Contrato> Contratos { get; set; }
        public virtual IList<Imagem> Imagens { get; set; }
        public virtual IList<PeriodoTurma> PeriodosModalidades { get; set; }
        public virtual IList<Treino> Treinos { get; set; }        

        public Colaborador()
        {
            Contratos = new List<Contrato>();
            Imagens = new List<Imagem>();
            PeriodosModalidades = new List<PeriodoTurma>();
            Treinos = new List<Treino>();
        }
    }
}
