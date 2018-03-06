using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    public class EquipamentoAparelho
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [MaxLength(50, ErrorMessage = "Nome do equipamento/aparelho não pode ultrapassar 50 caracteres")]
        public string Nome { get => Nome; set => Nome = value.Length > 50 ? value.Substring(0, 50) : value; }
        [Range(0, 999999.99, ErrorMessage = "Valor não pode ser negativo")]
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public DateTime DataAdd { get; set; }
        public bool Possui { get; set; }
        #endregion
    }
}
