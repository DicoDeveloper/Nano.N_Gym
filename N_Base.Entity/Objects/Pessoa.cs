using N_Base.Entity.Enums.Pessoa;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    [Table("PESSOAS")]
    public class Pessoa
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column("ID")]
        public long Id { get; set; }
        [Column("CODIGO"), Required(ErrorMessage = "Código é obrigatório")]
        public long Codigo { get; set; }
        [MaxLength(80, ErrorMessage = "Nome não pode ultrapassar 80 caracteres"), Required(ErrorMessage = "Informar o nome é obrigatório")]
        [Column("NOME")]
        public string Nome { get => Nome; set => Nome = value.Length > 80 ? value.Substring(0, 80) : value; }
        [Column("SEXO"), Required]
        public TipoSexo Sexo { get; set; }
        [MaxLength(18, ErrorMessage = "CPF/CNPJ não pode passar de 18 caracteres")]
        [Column("CADASTRO_PF_PJ")]
        public string Registro { get => Registro; set => Registro = value.Length > 18 ? value.Substring(0, 18) : value; }
        [ForeignKey("Endereco"), Column("ID_ENDERECO")]
        public long IdEndereco { get; set; }
        [MaxLength(10, ErrorMessage = "Numero do logradouro não pode ultrapassar 10 caracteres")]
        [Column("NUM_LOGRADOURO")]
        public string NrLogradouro { get => NrLogradouro; set => NrLogradouro = value.Length > 10 ? value.Substring(0, 10) : value; }
        [MaxLength(15, ErrorMessage = "Complemanto não pode ultrapassar 15 caracteres")]
        [Column("COMPLEMENTO")]
        public string Complemento { get => Complemento; set => Complemento = value.Length > 15 ? value.Substring(0, 15) : value; }
        [MaxLength(15, ErrorMessage = "Telefone não pode ultrapassar 15 caracteres")]
        [Column("FONE")]
        public string Fone { get => Fone; set => Fone = value.Length > 15 ? value.Substring(0, 15) : value; }
        [MaxLength(16, ErrorMessage = "Celular não pode ultrapassar 16 caracteres")]
        [Column("CEL")]
        public string Cel { get => Cel; set => Cel = value.Length > 16 ? value.Substring(0, 16) : value; }
        [MaxLength(40, ErrorMessage = "Endereço de email não pode ultrapassar 40 caracteres")]
        [Column("EMAIL")]
        public string Email { get => Email; set => Email = value.Length > 40 ? value.Substring(0, 40) : value; }
        [Column("DAT_NASCIMENTO")]
        public DateTime Nascimento { get; set; }
        [Column("DAT_CADASTRO")]
        public DateTime DataCadastrado { get; set; }
        [Column("ESTADO_CIVIL")]
        public TipoEstadoCivil EstadoCivil { get; set; }
        [Column("ATIVO")]
        public bool Ativo { get; set; }        
        public virtual Endereco Endereco { get; set; }
        #endregion
    }
}
