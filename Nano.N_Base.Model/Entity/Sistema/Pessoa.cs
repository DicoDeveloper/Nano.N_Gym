using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Nano.N_Base.Model.Entity.Sistema
{
    public class Pessoa : EntityBase
    {
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(18)]
        public string CpfCnpj { get; set; }
        public DateTime DataCadastrado { get; set; }

        public virtual IList<Caracteristica> Caracteristicas { get; set; }
        public virtual IList<Endereco> Enderecos { get; set; }

        public Pessoa()
        {
            Caracteristicas = new List<Caracteristica>();
            Enderecos = new List<Endereco>();
        }
    }
}
