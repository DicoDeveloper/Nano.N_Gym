using Nano.N_Base.Model.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("LOCALIZACOES")]
    public class Localizacao : EntityBaseEmpresa
    {
        [ForeignKey("Pai")]
        public long? IdPai { get; set; }
        [MaxLength(60), Required]
        public string Descricao { get; set; }
        public decimal? Comprimento { get; set; }
        public decimal? Largura { get; set; }
        public decimal? Altura { get; set; }
        public string Observacoes { get; set; }

        public virtual Localizacao Pai { get; set; }
        public virtual IList<Aparelho> Aparelhos { get; set; }
        public virtual IList<Localizacao> Filhos { get; set; }
        public virtual IList<Imagem> Imagens { get; set; }
        public virtual IList<Modalidade> Modalidades { get; set; }
        public virtual IList<PeriodoTurma> PeriodosTurmas { get; set; }

        public Localizacao()
        {
            Aparelhos = new List<Aparelho>();
            Filhos = new List<Localizacao>();
            Imagens = new List<Imagem>();
            Modalidades = new List<Modalidade>();
            PeriodosTurmas = new List<PeriodoTurma>();
        }
    }
}
