//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PessoaWCF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UF
    {
        public UF()
        {
            this.CIDADES = new HashSet<CIDADE>();
        }
    
        public string SIGLA_UF { get; set; }
        public string NOME_UF { get; set; }
    
        public virtual ICollection<CIDADE> CIDADES { get; set; }
    }
}
