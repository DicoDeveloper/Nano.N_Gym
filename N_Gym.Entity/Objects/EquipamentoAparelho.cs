using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("EQUIPAMENTOS_APARELHOS")]
    public class EquipamentoAparelho
    {
        #region Propriedades
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_EQUIPAMENTO_APARELHO")]
        public long Id { get; set; }
        [MaxLength(50, ErrorMessage = "Nome do equipamento/aparelho não pode ultrapassar 50 caracteres")]
        [Column("NOME")]
        public string Nome { get => Nome; set => Nome = value.Length > 50 ? value.Substring(0, 50) : value; }
        [Range(0, 999999.99, ErrorMessage = "Valor não pode ser negativo")]
        [Column("VAL_EQUIP_APAR")]
        public decimal Valor { get; set; }
        [Column("DESCRIICAO")]
        public string Descricao { get; set; }
        [Column("DAT_ADQUIRIDO")]
        public DateTime DataAdd { get; set; }
        [Column("POSSUI")]
        public bool Possui { get; set; }
        #endregion
    }
}
