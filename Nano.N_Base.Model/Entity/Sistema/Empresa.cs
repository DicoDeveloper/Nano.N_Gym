using Nano.N_Base.Model.Entity.Financeiro;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity.Sistema
{
    [Table("EMPRESAS")]
    public class Empresa : Pessoa
    {
        [MaxLength(80)]
        public string NomeFantasia { get; set; }

        public virtual IList<ColaboradorBase> Colaboradores { get; set; }
        public virtual IList<DespesaReceita> DespesasReceitas { get; set; }
        public virtual IList<MeioPagamento> MeiosPagamentos { get; set; }
        public virtual IList<Usuario> Usuarios { get; set; }

        public Empresa()
        {
            Colaboradores = new List<ColaboradorBase>();
            DespesasReceitas = new List<DespesaReceita>();
            MeiosPagamentos = new List<MeioPagamento>();
            Usuarios = new List<Usuario>();
        }
    }
}
