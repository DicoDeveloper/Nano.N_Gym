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
        public virtual IList<Anamnese> Anamnesias { get; set; }
        public virtual IList<AvaliacaoAntropometrica> Antropometricas { get; set; }
        public virtual IList<AvaliacaoCompleta> Completas { get; set; }
        public virtual IList<AvaliacaoComposicaoCorporal> ComposicoesCorporal { get; set; }
        public virtual IList<AvaliacaoIMC> IMCs { get; set; }
        public virtual IList<AvaliacaoPerimetria> Perimetrias { get; set; }
        public virtual IList<AvaliacaoRCQ> RCQs { get; set; }
        public virtual IList<AvaliacaoRiscoCoronariano> RiscosCoronariano { get; set; }
        public virtual IList<Treino> Treinos { get; set; }
        public virtual IList<Contrato> Contratos { get; set; }
        public virtual IList<PARQ> PARQs { get; set; }

        public Cliente()
        {
            Anamnesias = new List<Anamnese>();
            Antropometricas = new List<AvaliacaoAntropometrica>();
            Completas = new List<AvaliacaoCompleta>();
            ComposicoesCorporal = new List<AvaliacaoComposicaoCorporal>();
            IMCs = new List<AvaliacaoIMC>();
            Perimetrias = new List<AvaliacaoPerimetria>();
            RCQs = new List<AvaliacaoRCQ>();
            RiscosCoronariano = new List<AvaliacaoRiscoCoronariano>();
            Treinos = new List<Treino>();
            Contratos = new List<Contrato>();
            PARQs = new List<PARQ>();
        }
    }
}
