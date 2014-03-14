using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _001_Controller.Models
{
    [Table("PARAMETRO")]
    public class Parametro
    {
        [Display(Name = "Código")]
        [Column("COD_PARAMETRO")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Chave")]
        [Required(ErrorMessage = "Preencha o campo chave")]
        [Column("CHAVE_PARAMETRO")]
        public String Chave { get; set; }

        [Display(Name = "Conteúdo")]
        [Required(ErrorMessage = "Preencha o campo conteúdo")]
        [Column("CONTEUDO_PARAMETRO")]
        public String Conteudo { get; set; }
    }
}