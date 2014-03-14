using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _001_Model.Models
{
    [MetadataType(typeof(PessoaMetadata))]
    partial class Pessoa
    {

    }

    public class PessoaMetadata
    {
        [Display(Name = "Código")]
        public int Cod { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage="Campo obrigatório")]
        public String Nome { get; set; }
    }
}