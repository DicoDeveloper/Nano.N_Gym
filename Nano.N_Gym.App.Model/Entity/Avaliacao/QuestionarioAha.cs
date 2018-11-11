using Nano.N_Base.Model.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity.Avaliacao
{
    [Table("QUESTIONARIOS_AHA")]
    public class QuestionarioAha : EntityBase
    {
        [ForeignKey("Anaminese")]
        public long IdAnaminese { get; set; }
        public bool AtaqueCardiaco { get; set; }
        public bool CirurgiaCardiaca { get; set; }
        public bool CateterizacaoCardiaca { get; set; }
        public bool AngioplastiaCoronaria { get; set; }
        public bool ImplanteMarcapasso { get; set; }
        public bool TransplanteCardiaco { get; set; }
        public bool ColapsoCaridaco { get; set; }
        public bool DoencaValvulaCardiaca { get; set; }
        public bool DesfibrilacaoDisturbioRitmoCardiaco { get; set; }
        public bool DoencaCardiacaCcongenita { get; set; }
        public bool AsmaDoencaPulmonar { get; set; }
        public bool ProblemaMussculoEsqueletico { get; set; }
        public bool PreocupacoesAoExercitar { get; set; }
        public bool PossuiDoencaTireoideRinsFigado { get; set; }
        public bool EstaGravida { get; set; }
        public bool DesconfortoPeitoEsforco { get; set; }
        public bool FaltaArSubita { get; set; }
        public bool TonturasDesmaiosPerdaDeSentidos { get; set; }
        public bool UsaUsouMedicacaoParaCoração { get; set; }
        public bool FumaFumouHaMenos6Meses { get; set; }
        public bool PressaoArterialSuperior140_90mmHg { get; set; }
        public bool ColesterolSuperior200mg_dL { get; set; }
        public bool PaiIrmaoAtaqueOuCirurgiaCardiacaAtensDos55 { get; set; }
        public bool AcucarSuperioIdeal { get; set; }
        public bool Faz120MinSemanaAtividadesFisicasModeradas { get; set; }
        public bool AcimaPesoIdeal9Kg { get; set; }
        public bool Outros { get; set; }
        public bool PrecisaAcompanhamentoMedico { get; set; }

        public virtual Anamnese Anaminese { get; set; }
    }
}
