﻿using Nano.N_Base.Model.Entity;
using Nano.N_Gym.App.Model.Enum.Modalidade;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("PERIODOS_MODALIDADES")]
    public class PeriodoModalidade : EntityBasePorEmpresa
    {
        [ForeignKey("Modalidade"), Required]
        public long IdModalidade { get; set; }
        [Required]
        public DiaSemana DiaSemana { get; set; }
        [Required]
        public string HrInicio { get; set; }
        [Required]
        public string HrFim { get; set; }

        public virtual Modalidade Modalidade { get; set; }
    }
}
