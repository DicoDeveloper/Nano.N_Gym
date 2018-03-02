using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using N_Base.Entity.Enums.Data;

namespace N_Base.Entity.Objects
{
    public class CentroCusto
    {
        #region Propriedades
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [MaxLength(200, ErrorMessage = "Descrição não pode passar de 200 caracteres"), Required(ErrorMessage = "Descrição é obrigatório")]
        public string Descricao { get => Descricao; set => Descricao = value.Length > 200 ? value.Substring(0, 200) : value; }
        public bool Fixo { get; set; }
        public bool Baixa { get; set; }
        public TipoIndicador TipoIndicador { get; set; }
        #endregion
    }
}
