﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Nano.N_Base.Model.Entity
{
    [Table("EMPRESAS")]
    public class Empresa : Pessoa
    {
        public string CNPJ { get; set; }
    }
}