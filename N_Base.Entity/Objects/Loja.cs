using System.ComponentModel.DataAnnotations;

namespace N_Base.Entity.Objects
{
    public class Loja
    {
        #region Propriedades
        public long Id { get; set; }
        [MaxLength(60)]
        public string Proprietario { get => Proprietario; set => Proprietario = value.Length > 60 ? value.Substring(0, 60) : value; }
        [MaxLength(50)]
        public string NomeFantasia { get => NomeFantasia; set => NomeFantasia = value.Length > 50 ? value.Substring(0, 50) : value; }
        [MaxLength(18)]
        public string Registro { get => Registro; set => Registro = value.Length > 18 ? value.Substring(0, 18) : value; }
        public long IdEndereco { get; set; }
        [MaxLength(10)]
        public string NumLogradouro { get => NumLogradouro; set => NumLogradouro = value.Length > 10 ? value.Substring(0, 10) : value; }
        [MaxLength(15)]
        public string Complemento { get => Complemento; set => Complemento = value.Length > 15 ? value.Substring(0, 15) : value; }
        [MaxLength(15)]
        public string Fone { get => Fone; set => Fone = value.Length > 15 ? value.Substring(0, 15) : value; }
        [MaxLength(40)]
        public string FraseCupom { get => FraseCupom; set => FraseCupom = value.Length > 40 ? value.Substring(0, 40) : value; }
        #endregion
    }
}
