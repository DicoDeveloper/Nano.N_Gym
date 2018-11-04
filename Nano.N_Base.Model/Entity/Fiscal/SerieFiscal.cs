using Nano.N_Base.Model.Enum.Fiscal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Fiscal
{
    [Table("SERIES_FISCAIS")]
    public class SerieFiscal : EntityBase
    {
        [Range(1, 999)]
        public int Codigo { get; set; }
        [ForeignKey("Modelo")]
        public long IdModelo { get; set; }
        [Range(1, 999999)]
        public int Serie { get; set; }
        [Range(1, 999999)]
        public int? SubSerie { get; set; }
        [MaxLength(60)]
        public string Descricao { get; set; }
        public TipoAplicacao Aplicacao { get; set; }

        public virtual ModeloFiscal Modelo { get; set; }
    }
}
