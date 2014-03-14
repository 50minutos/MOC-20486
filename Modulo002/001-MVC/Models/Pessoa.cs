using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _001_MVC.Models
{
    public partial class Pessoa
    {
        [Display(Name = "CÓDIGO")]
        public int Codigo { get; set; }

        [Display(Name = "NOME DO SUJEITO")]
        public String Nome { get; set; }
    }
}