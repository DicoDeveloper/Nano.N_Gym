using N_Base.Entity.Enums.Pessoa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace N_Base.Entity.Objects
{
    public class Pessoa
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }        
        [MaxLength(80, ErrorMessage = "Nome não pode ultrapassar 80 caracteres"), Required(ErrorMessage = "Informar o nome é obrigatório")]
        public string Nome { get => Nome; set => Nome = value.Length > 80 ? value.Substring(0, 80) : value; }
        [Required]
        public TipoSexo Sexo { get; set; }
        [MaxLength(18, ErrorMessage = "CPF/CNPJ não pode passar de 18 caracteres")]
        public string Registro { get => Registro; set => Registro = value.Length > 18 ? value.Substring(0, 18) : value; }
        [MaxLength(10, ErrorMessage = "Numero do logradouro não pode ultrapassar 10 caracteres")]
        public string NrLogradouro { get => NrLogradouro; set => NrLogradouro = value.Length > 10 ? value.Substring(0, 10) : value; }
        [MaxLength(15, ErrorMessage = "Complemanto não pode ultrapassar 15 caracteres")]
        public string Complemento { get => Complemento; set => Complemento = value.Length > 15 ? value.Substring(0, 15) : value; }
        [MaxLength(15, ErrorMessage = "Telefone não pode ultrapassar 15 caracteres")]
        public string Fone { get => Fone; set => Fone = value.Length > 15 ? value.Substring(0, 15) : value; }
        [MaxLength(16, ErrorMessage = "Celular não pode ultrapassar 16 caracteres")]
        public string Cel { get => Cel; set => Cel = value.Length > 16 ? value.Substring(0, 16) : value; }
        [MaxLength(40, ErrorMessage = "Endereço de email não pode ultrapassar 40 caracteres")]
        public string Email { get => Email; set => Email = value.Length > 40 ? value.Substring(0, 40) : value; }
        public DateTime Nascimento { get; set; }
        public DateTime DataCadastrado { get; set; }
        public TipoEstadoCivil EstadoCivil { get; set; }
        public bool Ativo { get; set; }
        public virtual List<EnderecoPessoa> EnderecoPessoas { get; set; }
        #endregion

        public Pessoa() => EnderecoPessoas = new List<EnderecoPessoa>();
    }
}
