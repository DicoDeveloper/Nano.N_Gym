using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using N_Sale.Entity.Enums;

namespace N_Sale.Entity.Objects
{
    public class Produto
    {
        #region Propriedades
        public long Id { get; set; }
        [ForeignKey("Estoque")]
        public long IdEstoque { get; set; }
        [Required(ErrorMessage = "Código do produto é obrigatório")]
        public long Codigo { get; set; }
        [MaxLength(25, ErrorMessage = "Código de barras não pode ultrapassar 25 caracteres")]
        public string CodBarras { get => CodBarras; set => CodBarras = value.Length > 25 ? value.Substring(0, 25) : value; }
        public string[] BarrasAuxiliar { get; set; }
        [MaxLength(50, ErrorMessage = "Nome do produto não pode ultrapassar 50 caracteres"), Required(ErrorMessage = "Nome é obrigatório")]
        public string Descricao { get; set; }
        [Range(0.01, 999999.99, ErrorMessage = "Valor do produto não pode ser zero"), Required(ErrorMessage = "Valor do produto é obrigatório")]
        public decimal ValorUnitario { get; set; }
        public string Observacao { get; set; }
        [MaxLength(30, ErrorMessage = "Marca não pode passar de 30 caracteres")]
        public string Marca { get => Marca; set => Marca = value.Length > 30 ? value.Substring(0, 30) : value; }
        public string Foto { get; set; }
        public TipoMedida TipoMedida { get; set; }
        [MaxLength(5, ErrorMessage = "Valor da medida não pode passar de 5 caracteres")]
        public string ValorMedida { get => ValorMedida; set => ValorMedida = value.Length > 5 ? value.Substring(0, 5) : value; }
        public bool VendaKg { get; set; }
        public virtual Estoque Estoque { get; set; }
        public virtual List<Perda> Perdas { get; set; }
        #endregion

        public Produto()
        {
            Perdas = new List<Perda>();
        }
    }
}