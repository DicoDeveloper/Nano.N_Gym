using System.ComponentModel.DataAnnotations;
using N_Base.Entity.Objects;

namespace N_Sale.Entity.Objects
{
    public class Fornecedor : Pessoa
    {
        #region Propriedades        
        [MaxLength(16, ErrorMessage = "Telefone 2 não pode ultrapassar 16 caracteres")]
        public string Fone2 { get => Fone2; set => Fone2 = value.Length > 16 ? value.Substring(0, 16) : value; }
        [MaxLength(16, ErrorMessage = "Celular 2 não pode ultrapassar 16 caracteres")]
        public string Cel2 { get => Cel2; set => Cel2 = value.Length > 16 ? value.Substring(0, 16) : value; }
        public string Observacao { get; set; }
        [MaxLength(50, ErrorMessage = "Nome da empresa não pode ultrapassar 50 caracteres")]
        public string Empresa { get => Empresa; set => Empresa = value.Length > 50 ? value.Substring(0, 50) : value; }
        #endregion
    }
}