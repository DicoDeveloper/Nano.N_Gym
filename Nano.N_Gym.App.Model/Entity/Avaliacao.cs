using Nano.N_Base.Model.Entity;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Gym.App.Model.Enum.Avaliacao;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("AVALIACOES")]
    public class Avaliacao : EntityBase
    {
        [ForeignKey("Cliente")]
        public long IdCliente { get; set; }
        [ForeignKey("PersonalTrainer")]
        public long? IdFuncionario { get; set; }
        public int Idade { get; set; }
        [MaxLength(8)]
        public string PressaoArterial { get; set; }
        [MaxLength(8)]
        public string FcRepouso { get; set; }
        public int Estatura { get; set; }
        [Range(0.001, 999999.999, ErrorMessage = "Peso não pode ser zero")]
        public decimal Peso { get; set; }
        [MaxLength(8)]
        public string Flexibilidade { get; set; }
        public DateTime Data { get; set; }
        [MaxLength(8)]
        public string CircTorax { get; set; }
        [MaxLength(8)]
        public string CircCintura { get; set; }
        [MaxLength(8)]
        public string CircAbdome { get; set; }
        [MaxLength(8)]
        public string CircBracDir { get; set; }
        [MaxLength(8)]
        public string CircAntebraDir { get; set; }
        [MaxLength(8)]
        public string CircBracEsq { get; set; }
        [MaxLength(8)]
        public string CircAntebraEsq { get; set; }
        [MaxLength(8)]
        public string CircQuadril { get; set; }
        [MaxLength(8)]
        public string CircCoxaDir { get; set; }
        [MaxLength(8)]
        public string CircPantuDir { get; set; }
        [MaxLength(8)]
        public string CircCoxaEsq { get; set; }
        [MaxLength(8)]
        public string CircPantuEsq { get; set; }
        [MaxLength(8)]
        public string MassaMagraKg { get; set; }
        [MaxLength(8)]
        public string GorduraKg { get; set; }
        [MaxLength(8)]
        public string PesoIdealKg { get; set; }
        [MaxLength(8)]
        public string PesoExtraKg { get; set; }
        [MaxLength(8)]
        public string IMC { get; set; }
        [MaxLength(8)]
        public string FcMax { get; set; }
        [MaxLength(8)]
        public string MassaMagraPercent { get; set; }
        [MaxLength(8)]
        public string GorduraPercent { get; set; }
        [MaxLength(8)]
        public string GorduraPretend { get; set; }
        [MaxLength(8)]
        public string GorduraExtraPercent { get; set; }
        [MaxLength(20)]
        public string Classificacao { get; set; }
        [MaxLength(6)]
        public string CutAbdominal { get; set; }
        [MaxLength(6)]
        public string CutAxila { get; set; }
        [MaxLength(6)]
        public string CutCoxa { get; set; }
        [MaxLength(6)]
        public string CutPanturrilha { get; set; }
        [MaxLength(6)]
        public string CutSubescapular { get; set; }
        [MaxLength(6)]
        public string CutSuprailiaca { get; set; }
        [MaxLength(6)]
        public string CutTorax { get; set; }
        [MaxLength(6)]
        public string CutTriceps { get; set; }
        [MaxLength(30)]
        public string RCQ { get; set; }
        [MaxLength(30)]
        public string RiscoCoronariano { get; set; }
        public Protocolo Protocolo { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Funcionario PersonalTrainer { get; set; }
    }
}
