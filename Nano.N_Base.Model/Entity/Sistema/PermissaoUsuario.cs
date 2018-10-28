using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("PERMISSOES_USUARIOS")]
    public class PermissaoUsuario : EntityBase
    {
        [ForeignKey("Usuario")]
        public long IdUsuario { get; set; }
        public string PermissoesJson { get; set; }

        public virtual Usuario Usuario { get; set; }
        [NotMapped]
        public IList<ItemPermissaoUsuario> Itenspermissao { get; set; }

        public PermissaoUsuario()
        {
            try
            {
                Itenspermissao = string.IsNullOrEmpty(PermissoesJson) ? new List<ItemPermissaoUsuario>() : JsonConvert.DeserializeObject<List<ItemPermissaoUsuario>>(PermissoesJson);
            }
            catch
            {
                Itenspermissao = new List<ItemPermissaoUsuario>();
            }
        }
    }
}
