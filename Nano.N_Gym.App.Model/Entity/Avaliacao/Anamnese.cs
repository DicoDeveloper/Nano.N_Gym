using Nano.N_Base.Model.Entity;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Gym.App.Model.Enum.Anamnese;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("ANAMNESES")]
    public class Anamnese : EntityBase
    {
        [ForeignKey("Cliente")]
        public long? IdCliente { get; set; }
        [ForeignKey("Colaborador")]
        public long IdColaborador { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        [MaxLength(14)]
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public string Nacionalidade { get; set; }
        [ForeignKey("Endereco")]
        public long IdEndereco { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Whatsapp { get; set; }
        public string PessoasParaAvisar { get; set; }
        public string PlanoSaude { get; set; }
        public decimal Peso { get; set; }
        public int Estatura { get; set; }
        [MaxLength(6)]
        public string FCRepouso { get; set; }
        public string QualObjetivo { get; set; }
        public bool SobrepesoInfancia { get; set; }
        public bool PaisSobrepeso { get; set; }
        public string AtividadesPraticadaJson { get; set; }
        public NivelAtividadeFisica NivelAtividadeFisica { get; set; }
        public int RefeicoesDia { get; set; }
        public decimal LitrosAguaDia { get; set; }
        public string FazDietaSuplementacao { get; set; }
        public TipoConsumoBebidaAlcoolica BebidaAlcoolica { get; set; }
        public bool Tabagista { get; set; }
        public int? CigarrosDia { get; set; }
        public string QuantoTempoParouCigarro { get; set; }
        public bool ColesterolAlto { get; set; }
        public string HDL { get; set; }
        public string LDL { get; set; }
        public bool TrigliceridesAlto { get; set; }
        public TipoDiabete Diabete { get; set; }
        public TipoTratamentoDiabete TratamentoDiabete { get; set; }
        public string MedicamentoDroga { get; set; }
        public string EsteroideAnabolico { get; set; }
        public string Alergias { get; set; }
        public string Cirurgias { get; set; }
        public string LocalDor { get; set; }
        public string ProblemaOrtopedico { get; set; }
        public string RecomendacoesRestricoesPraticaExercicio { get; set; }
        public bool FezTesteEsforco { get; set; }
        public string Observacoes { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Colaborador Colaborador { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
