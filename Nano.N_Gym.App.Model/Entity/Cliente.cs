using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Gym.App.Model.Entity.Avaliacao;
using Nano.N_Gym.App.Model.Enum.Avaliacao;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("CLIENTES")]
    public class Cliente : Pessoa
    {
        [ForeignKey("Responsavel")]
        public long? IdResponsavel { get; set; }
        public string Apelido { get; set; }
        public decimal? Peso { get; set; }
        public bool AcessoLivre { get; set; }
        public Genero Genero { get; set; }        
        public bool PermissaoExporDados { get; set; }

        public virtual Cliente Responsavel { get; set; }
        public virtual IList<Anamnese> Anamnesias { get; set; }
        public virtual IList<MassaMuscular> Antropometricas { get; set; }
        public virtual IList<ComposicaoCorporal> ComposicoesCorporal { get; set; }
        public virtual IList<Contrato> Contratos { get; set; }
        public virtual IList<Cliente> Dependentes { get; set; }
        public virtual IList<DobrasCutaneas> DobrasCutaneas { get; set; }
        public virtual IList<Imagem> Imagens { get; set; }
        public virtual IList<IMC> IMCs { get; set; }
        public virtual IList<PARQ> PARQs { get; set; }
        public virtual IList<Perimetria> Perimetrias { get; set; }
        public virtual IList<Proficao> Proficoes { get; set; }
        public virtual IList<QuestionarioAha> QuestionariosAha { get; set; }
        public virtual IList<RCQ> RCQs { get; set; }
        public virtual IList<RiscoCoronariano> RiscosCoronariano { get; set; }
        public virtual IList<Treino> Treinos { get; set; }

        public Cliente()
        {
            Anamnesias = new List<Anamnese>();
            Antropometricas = new List<MassaMuscular>();
            ComposicoesCorporal = new List<ComposicaoCorporal>();
            Contratos = new List<Contrato>();
            Dependentes = new List<Cliente>();
            DobrasCutaneas = new List<DobrasCutaneas>();
            Imagens = new List<Imagem>();
            IMCs = new List<IMC>();
            PARQs = new List<PARQ>();
            Perimetrias = new List<Perimetria>();
            Proficoes = new List<Proficao>();
            QuestionariosAha = new List<QuestionarioAha>();
            RCQs = new List<RCQ>();
            RiscosCoronariano = new List<RiscoCoronariano>();
            Treinos = new List<Treino>();
        }
    }
}
