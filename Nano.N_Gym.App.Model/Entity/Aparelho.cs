using Nano.N_Base.Model.Entity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Gym.App.Model.Entity
{
    [Table("APARELHOS")]
    public class Aparelho : EntityBaseEmpresa
    {
        [MaxLength(80)]
        public string Nome { get; set; }        
        public string Descricao { get; set; }
        [MaxLength(20)]
        public string Numeracao { get; set; }
        [Range(0, 999999.99)]
        public decimal? ValorAquisicao { get; set; }
        public DateTime? DataAquisicao { get; set; }
        public DateTime? DataTransferencia { get; set; }
    }
}
