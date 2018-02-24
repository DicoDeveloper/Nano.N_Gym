using N_Gym.Entity.Enums.Avaliacao;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("AVALIACOES")]
    public class Avaliacao
    {
        #region Propriedades
        [Column("ID_AVALIACAO")]
        public long Id { get; set; }
        [ForeignKey("Cliente"),Column("ID_CLIENTE"), Required]
        public long IdCliente { get; set; }
        [Column("IDADE")]
        public int Idade { get; set; }
        [MaxLength(8), Column("PRESSAO_ARTERIAL")]
        public string PresArterial { get; set; }
        [MaxLength(8), Column("FC_REPOUSO")]
        public string FcRepouso { get; set; }
        [Column("ESTATURA")]
        public int Estatura { get; set; }
        [Range(0.001, 999999.999, ErrorMessage = "Peso não pode ser zero"), Column("PESO")]
        public double Peso { get; set; }
        [MaxLength(8), Column("FLEXIBILIDADE")]
        public string Flexibilidade { get; set; }
        [Column("DAT_AVALIACAO")]
        public DateTime Data { get; set; }
        [MaxLength(8), Column("CIRCUNF_TORAX")]
        public string CircTorax { get; set; }
        [MaxLength(8), Column("CIRCUNF_CINTURA")]
        public string CircCintura { get; set; }
        [MaxLength(8), Column("CIRCUNF_ABDOME")]
        public string CircAbdome { get; set; }
        [MaxLength(8), Column("CIRCUNF_BRACO_DIR")]
        public string CircBracDir { get; set; }
        [MaxLength(8), Column("CIRCUNF_ANTEBRACO_DIR")]
        public string CircAntebraDir { get; set; }
        [MaxLength(8), Column("CIRCUNF_BRACO_ESQ")]
        public string CircBracEsq { get; set; }
        [MaxLength(8), Column("CIRCUNF_ANTEBRACO_ESQ")]
        public string CircAntebraEsq { get; set; }
        [MaxLength(8), Column("CIRCUNF_QUADRIL")]
        public string CircQuadril { get; set; }
        [MaxLength(8), Column("CIRCUNF_COXA_DIR")]
        public string CircCoxaDir { get; set; }
        [MaxLength(8), Column("CIRCUNF_PANTURRILHA_DIR")]
        public string CircPantuDir { get; set; }
        [MaxLength(8), Column("CIRCUNF_COXA_ESQ")]
        public string CircCoxaEsq { get; set; }
        [MaxLength(8), Column("CIRCUNF_PANTURRILHA_ESQ")]
        public string CircPantuEsq { get; set; }
        [MaxLength(8), Column("MASSA_MAGRA_KG")]
        public string MassaMagraKg { get; set; }
        [MaxLength(8), Column("GORDURA_KG")]
        public string GorduraKg { get; set; }
        [MaxLength(8), Column("PESO_IDEAL_KG")]
        public string PesoIdealKg { get; set; }
        [MaxLength(8), Column("PESO_EXTRA_KG")]
        public string PesoExtraKg { get; set; }
        [MaxLength(8), Column("IMC")]
        public string IMC { get; set; }
        [MaxLength(8), Column("FC_MAX")]
        public string FcMax { get; set; }
        [MaxLength(8), Column("MASSA_MAGRA_PERCENT")]
        public string MassaMagraPercent { get; set; }
        [MaxLength(8), Column("GORDURA_PERCENT")]
        public string GorduraPercent { get; set; }
        [MaxLength(8), Column("GORDURA_PRETENDIDA")]
        public string GorduraPretend { get; set; }
        [MaxLength(8), Column("GORDURA_EXTRA_PERCENT")]
        public string GorduraExtraPercent { get; set; }
        [MaxLength(20), Column("CLASSIFICACAO")]
        public string Classificacao { get; set; }
        [MaxLength(6), Column("CUTAN_ABDOMINAL")]
        public string CutAbdominal { get; set; }
        [MaxLength(6), Column("CUTAN_AXILA")]
        public string CutAxila { get; set; }
        [MaxLength(6), Column("CUTAN_COXA")]
        public string CutCoxa { get; set; }
        [MaxLength(6), Column("CUTAN_PANTURRILHA")]
        public string CutPanturrilha { get; set; }
        [MaxLength(6), Column("CUTAN_SUBESCAPULAR")]
        public string CutSubescapular { get; set; }
        [MaxLength(6), Column("CUTAN_SUPRAILIACA")]
        public string CutSuprailiaca { get; set; }
        [MaxLength(6), Column("CUTAN_TORAX")]
        public string CutTorax { get; set; }
        [MaxLength(6), Column("CUTAN_TRICEPS")]
        public string CutTriceps { get; set; }
        [MaxLength(30), Column("RCQ")]
        public string RCQ { get; set; }
        [MaxLength(30), Column("RISCO_CORONARIANO")]
        public string RiscoCoronariano { get; set; }
        [Column("PROTOCOLO")]
        public TipoProtocoloAvaliacao Protocolo { get; set; }
        public virtual ClienteGym Cliente { get; set; }
        #endregion
    }
}
