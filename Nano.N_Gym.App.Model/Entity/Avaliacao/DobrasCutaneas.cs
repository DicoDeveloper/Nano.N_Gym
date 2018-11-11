using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("DOBRAS_CUTANEAS")]
    public class DobrasCutaneas : EntityBase
    {
        [ForeignKey("Base")]
        public long IdBase { get; set; }
        public int? DCAbdominal { get; set; }
        public int? DCAxilaMedia { get; set; }
        public int? DCCoxa { get; set; }
        public int? DCPanturrilha { get; set; }
        public int? DCSubescapular { get; set; }
        public int? DCSuprailiaca { get; set; }
        public int? DCTorax { get; set; }
        public int? DCTriceps { get; set; }     

        public virtual AvaliacaoBase Base { get; set; }
    }
}
