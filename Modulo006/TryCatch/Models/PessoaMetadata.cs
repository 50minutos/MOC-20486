using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace _001_TryCatch.Models
{
    public class PessoaMetadata
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }
        
        [Required(ErrorMessage="Preencha o nome")]
        public String Nome { get; set; }
    }
}
