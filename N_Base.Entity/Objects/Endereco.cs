using N_Base.Entity.Enums.Endereco;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    [Table("ENDERECOS")]
    public class Endereco
    {
        #region Propriedades
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID_ENDERECO")]
        public long Id { get; set; }
        [Column("CODIGO"), Required(ErrorMessage = "Código é obrigatório")]
        public long Codigo { get; set; }
        [MaxLength(70, ErrorMessage = "Logradouro não pode ultrpassar 70 caracteres")]
        [Column("LOGRADOURO"), Required(ErrorMessage = "É nescessario informar logradouro")]
        public string Logradouro { get => Logradouro; set => Logradouro = value.Length > 70 ? value.Substring(0, 70) : value; }
        [MaxLength(40, ErrorMessage = "Nome da cidade não pode ultrapassar 40 caracteres")]
        [Column("CIDADE"), Required(ErrorMessage = "Nome da cidade é obrigatório")]
        public string Cidade { get => Cidade; set => Cidade = value.Length > 40 ? value.Substring(0, 40) : value; }
        [Column("UF"), Required(ErrorMessage = "Unidade Federativa é obrigatório")]
        public UF UF { get; set; }
        public virtual List<Pessoa> Pessoas { get; set; }
        #endregion

        public Endereco()
        {
            Pessoas = new List<Pessoa>();
        }
    }
}
