using Nano.N_Base.Model.Entity.Sistema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity
{
    public class EntityBaseEmpresa : EntityBase
    {
        [Required, ForeignKey("Empresa")]
        public long IdEmpresa { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
