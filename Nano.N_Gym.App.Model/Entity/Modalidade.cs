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
        public virtual IList<PeriodoModalidade> Periodos { get; set; }
        public virtual IList<Empresa> Empresas { get; set; }

        public Modalidade()
        {            
            Contratos = new List<Contrato>();
            Periodos = new List<PeriodoModalidade>();
            Empresas = new List<Empresa>();
        }
    }
}
