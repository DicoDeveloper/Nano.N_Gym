using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("PERMISSOES_USUARIOS")]
    public class PermissaoUsuario : EntityBase
    {
        public string PermissoesJson { get; set; }

        [NotMapped]
        public virtual IList<ItemPermissaoUsuario> Itenspermissao { get; set; }

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
