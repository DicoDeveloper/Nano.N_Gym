using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("FICHAS_AVALIACOES_CLIENTES")]
    public class FichaAvaliacaoCliente
    {
        #region
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_FICHA_AVALIA_CLI")]
        public long Id { get; set; }
        [Column("ID_CLIENTE"), ForeignKey("Cliente")]
        public long IdCliente { get; set; }
        [Column("IDADE_CLIENTE")]
        public int Idade { get; set; }
        [Column("PROFICAO")]
        public string Proficao { get; set; }
        [Column("QUAL_OBJETIVO")]
        public string QualObjetivo { get; set; }
        [Column("FAZ_DIETA")]
        public bool FazDieta { get; set; }
        [Column("PRATICA_EXERCICIO")]
        public bool PraticaExercicio { get; set; }
        [Column("QUAIS_EXERRCICIOS")]
        public string QuaisExerc { get; set; }
        [Column("INTENCIDADE_PRATICA")]
        public string IntenciPrat { get; set; }
        [Column("SUBMETIDO_EXAMES")]
        public bool SubmetidoExames { get; set; }
        [Column("QUAIS_EXAMES")]
        public string QuaisExames { get; set; }
        [Column("OBSERVACOES")]
        public string Observacoes { get; set; }
        [Column("TABAGISTA")]
        public bool Tabagista { get; set; }
        [Column("CIGARROS_DIA")]
        public int CigarDias { get; set; }
        [Column("LESOES_OSTEO")]
        public bool LesoesOsteo { get; set; }
        [Column("SENTE_DOR")]
        public bool SenteDor { get; set; }
        [Column("ONDE_DOI")]
        public string OndeDoi { get; set; }
        [Column("HISTORICO_FAMILIAR")]
        public string HistoricoFami { get; set; }
        public virtual ClienteGym Cliente { get; set; }
        #endregion
    }
}
