using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("PERIMETRIAS")]
    public class Perimetria : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        public decimal? Abdome { get; set; }
        public decimal? AntebracoDireito { get; set; }
        public decimal? AntebracoEsquerdo { get; set; }
        public decimal? BracoDireitoContraido { get; set; }
        public decimal? BracoDireitoRelaxado { get; set; }        
        public decimal? BracoEsquerdoContraido { get; set; }
        public decimal? BracoEsquerdoRelaxado { get; set; }
        public decimal? Cintura { get; set; }
        public decimal? CoxaDistalDireita { get; set; }
        public decimal? CoxaDistalEsquerda { get; set; }
        public decimal? CoxaMediaDireita { get; set; }
        public decimal? CoxaMediaEsquerda { get; set; }
        public decimal? CoxaProximalDireita { get; set; }
        public decimal? CoxaProximalEsquerda { get; set; }
        public decimal? Quadril { get; set; }
        public decimal? PanturrilhaDireita { get; set; }
        public decimal? PanturrilhaEsquerda { get; set; }
        public decimal? Pescoco { get; set; }
        public decimal? Torax { get; set; }

        public virtual AvaliacaoBase Base { get; set; }
    }
}
