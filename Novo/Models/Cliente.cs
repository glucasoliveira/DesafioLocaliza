//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Novo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public long Cpf { get; set; }
        public string Nome { get; set; }
        public long Cnh { get; set; }
        public string CategoriaCnh { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public System.DateTime DataNascimento { get; set; }
    }
}