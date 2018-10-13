using Nano.N_Base.Model.Interface;
using System;

namespace Nano.N_Base.Model.Entity
{
    public class EntityBase : IEntityBase
    {
        long IEntityBase.Id { get => Id; set => Id = value; }
        public long Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public Usuario UsuarioCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public Usuario UsuarioAlteracao { get; set; }        
    }
}
