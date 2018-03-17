using N_Base.Entity.Objects;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    public class Cliente : Pessoa
    {
        #region Propriedades
        [Required(ErrorMessage = "Código é obrigatório")]
        public long Codigo { get; set; }
        [ForeignKey("Responsavel")]
        public long IdResponsavel {get;set;}
        public string ControleModalidade { get; set; }
        public bool AcessoLivre { get; set; }
        public string Foto { get; set; }
        public virtual List<Avaliacao> Avaliacoes { get; set; }
        public virtual List<Treino> Treinos { get; set; }
        public virtual List<ConvenioCliente> ConveniosCliente { get; set; }
        public virtual List<Cliente> Dependentes { get; set; }
        public virtual List<Contrato> Contratos { get; set; }
        public virtual Cliente Responsavel { get; set; }
        #endregion

        public Cliente()
        {
            Avaliacoes = new List<Avaliacao>();
            Treinos = new List<Treino>();
            ConveniosCliente = new List<ConvenioCliente>();
            Dependentes = new List<Cliente>();
            Contratos = new List<Contrato>();
        }
    }
}
