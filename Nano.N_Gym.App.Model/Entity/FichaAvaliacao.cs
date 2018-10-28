using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("FICHAS_AVALIACOES")]
    public class FichaAvaliacao : EntityBase
    {
        [ForeignKey("Cliente")]
        public long IdCliente { get; set; }
        public string QualObjetivo { get; set; }
        public bool FazDieta { get; set; }
        public bool PraticaExercicio { get; set; }
        public string QuaisExercicios { get; set; }
        public string IntencidadePratica { get; set; }
        public bool SubmetidoExames { get; set; }
        public string QuaisExames { get; set; }
        public string Observacoes { get; set; }
        public bool Tabagista { get; set; }
        public int? CigarrosDia { get; set; }
        public bool LesoesOsteomusculares { get; set; }
        public bool SenteDor { get; set; }
        public string LocalDor { get; set; }
        public string HistoricoFamiliar { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
