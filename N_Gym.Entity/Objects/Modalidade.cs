using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Gym.Entity.Objects
{
    [Table("MODALIDADES")]
    public class Modalidade
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_MODALIDADE")]
        public long Id { get; set; }
        [MaxLength(50, ErrorMessage = "Nome da modalidade não pode ultrapassar 50 caracteres")]
        [Column("NOME"), Required]
        public string Nome { get => Nome; set => Nome = value.Length > 50 ? value.Substring(0, 50) : value; }
        [Range(0, 999999.99, ErrorMessage = "Valor não pode ser zero")]
        [Column("VAL_MODALIDADE"), Required]
        public decimal Valor { get; set; }
        [MaxLength(60, ErrorMessage = "Nome do personal não deve ultrapassar 60 caracteres")]
        [Column("PERSONAL")]
        public string Personal { get => Personal; set => Personal = value.Length > 60 ? value.Substring(0, 60) : value; }
        [Column("DESCRICAO")]
        public string Descricao { get; set; }
        [Column("POSSUI"), Required]
        public bool Possui { get; set; }
        public virtual ICollection<PeriodoModalidade> Periodos { get; set; }
        public virtual ICollection<ModalidadeCliente> Clientes { get; set; }
        #endregion
    }
}
