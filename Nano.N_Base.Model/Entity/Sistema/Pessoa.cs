using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    public class Pessoa : EntityBase
    {
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(18)]
        public string CPF_CNPJ { get; set; }        
        [MaxLength(18)]
        public string NumeroIdentidade { get; set; }
        public DateTime? Nascimento { get; set; }
        public DateTime Cadastrado { get; set; }

        public virtual IList<Caracteristica> Caracteristicas { get; set; }
        public virtual IList<Contato> Contatos { get; set; }
        public virtual IList<Endereco> Enderecos { get; set; }

        public Pessoa()
        {
            Caracteristicas = new List<Caracteristica>();
            Contatos = new List<Contato>();
            Enderecos = new List<Endereco>();
        }
    }
}
