using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _001_Controller.Models
{
    [Table("PESSOA")]
    public class Pessoa
    {
        [Display(Name = "Código")]
        [Column("COD_PESSOA")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage="Preencha o campo nome")]
        [Column("NOME_PESSOA")]
        public String Nome { get; set; }
    }
}