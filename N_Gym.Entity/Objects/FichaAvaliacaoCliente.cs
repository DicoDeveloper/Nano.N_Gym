using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    public class FichaAvaliacaoCliente
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [ForeignKey("Cliente")]
        public long IdCliente { get; set; }
        public int Idade { get; set; }
        public string Proficao { get; set; }
        public string QualObjetivo { get; set; }
        public bool FazDieta { get; set; }
        public bool PraticaExercicio { get; set; }
        public string QuaisExerc { get; set; }
        public string IntenciPrat { get; set; }
        public bool SubmetidoExames { get; set; }
        public string QuaisExames { get; set; }
        public string Observacoes { get; set; }
        public bool Tabagista { get; set; }
        public int CigarDias { get; set; }
        public bool LesoesOsteo { get; set; }
        public bool SenteDor { get; set; }
        public string OndeDoi { get; set; }
        public string HistoricoFami { get; set; }
        public virtual Cliente Cliente { get; set; }
        #endregion
    }
}
