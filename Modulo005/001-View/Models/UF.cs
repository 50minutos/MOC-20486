using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace _001_View.Models
{
    public class UF
    {
        [Display(Name = "Sigla")]
        public String Sigla { get; set; }

        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "Cidades")]
        public virtual ICollection<Cidade> Cidades { get; set; }
    }

    public class UFMap : EntityTypeConfiguration<UF>
    {
        public UFMap()
        {
            this.HasKey(t => t.Sigla);
            
            this.Property(t => t.Sigla)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            this.ToTable("UF");

            this.Property(t => t.Sigla)
                .HasColumnName("SIGLA_UF");
            
            this.Property(t => t.Nome)
                .HasColumnName("NOME_UF");
        }
    }
}