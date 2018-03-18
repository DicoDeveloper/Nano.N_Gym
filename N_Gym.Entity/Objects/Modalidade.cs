﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    public class Modalidade
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [MaxLength(50, ErrorMessage = "Nome da modalidade não pode ultrapassar 50 caracteres"), Required]
        public string Nome { get => Nome; set => Nome = value.Length > 50 ? value.Substring(0, 50) : value; }
        [Range(0, 999999.99, ErrorMessage = "Valor não pode ser zero"), Required]
        public decimal Valor { get; set; }
        [MaxLength(60, ErrorMessage = "Nome do personal não deve ultrapassar 60 caracteres")]
        public string Personal { get => Personal; set => Personal = value.Length > 60 ? value.Substring(0, 60) : value; }
        public string Descricao { get; set; }
        [Required]
        public bool Ativa { get; set; }
        public virtual List<PeriodoModalidade> Periodos { get; set; }
        public virtual List<ContratoModalidade> ContratosModalidades { get; set; }
        #endregion
    }
}
