using Nano.N_Base.Model.Entity;
using Nano.N_Base.Model.Entity.Sistema;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("MODALIDADES")]
    public class Modalidade : EntityBase
    {
        [MaxLength(80), Required]
        public string Nome { get; set; }
        [Range(0, 999999.99)]
        public decimal? Valor { get; set; }
        public string Descricao { get; set; }
        
        public virtual IList<Contrato> Contratos { get; set; }
        public virtual IList<Empresa> EmpresasBloqueadas { get; set; }
        public virtual IList<Localizacao> Localizacoes { get; set; }
        public virtual IList<Turma> Turmas { get; set; }

        public Modalidade()
        {            
            Contratos = new List<Contrato>();
            EmpresasBloqueadas = new List<Empresa>();
            Localizacoes = new List<Localizacao>();
            Turmas = new List<Turma>();

        }
    }
}
