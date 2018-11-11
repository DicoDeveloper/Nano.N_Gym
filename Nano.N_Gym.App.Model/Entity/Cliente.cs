using Nano.N_Base.Model.Entity;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Gym.App.Model.Entity.Avaliacao;
using Nano.N_Gym.App.Model.Enum.Avaliacao;
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
        public Genero Genero { get; set; }

        public virtual ClienteBase ClienteBase { get; set; }
        public virtual IList<Anamnese> Anamnesias { get; set; }
        public virtual IList<AvaliacaoAntropometrica> Antropometricas { get; set; }
        public virtual IList<ComposicaoCorporal> ComposicoesCorporal { get; set; }
        public virtual IList<DobrasCutaneas> DobrasCutaneas { get; set; }
        public virtual IList<IMC> IMCs { get; set; }
        public virtual IList<PARQ> PARQs { get; set; }
        public virtual IList<Perimetria> Perimetrias { get; set; }
        public virtual IList<QuestionarioAha> QuestionariosAha { get; set; }
        public virtual IList<RCQ> RCQs { get; set; }
        public virtual IList<RiscoCoronariano> RiscosCoronariano { get; set; }
        public virtual IList<Treino> Treinos { get; set; }
        public virtual IList<Contrato> Contratos { get; set; }

        public Cliente()
        {
            Anamnesias = new List<Anamnese>();
            Antropometricas = new List<AvaliacaoAntropometrica>();
            ComposicoesCorporal = new List<ComposicaoCorporal>();
            DobrasCutaneas = new List<DobrasCutaneas>();
            IMCs = new List<IMC>();
            PARQs = new List<PARQ>();
            Perimetrias = new List<Perimetria>();
            QuestionariosAha = new List<QuestionarioAha>();
            RCQs = new List<RCQ>();
            RiscosCoronariano = new List<RiscoCoronariano>();
            Treinos = new List<Treino>();
            Contratos = new List<Contrato>();
        }
    }
}
