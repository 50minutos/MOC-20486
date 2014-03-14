using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UfCidade.Models
{
    public class EstadoMetadata
    {
        [Display(Name="Sigla")]
        public String EstadoId { get; set; }

        [Display(Name = "Nome")]
        public String EstadoNome { get; set; }
    }

    [MetadataType(typeof(EstadoMetadata))]
    partial class Estado
    { 
    }
}
