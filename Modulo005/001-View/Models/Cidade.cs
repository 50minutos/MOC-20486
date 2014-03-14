using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace _001_View.Models
{
    public class Cidade
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        
        [Display(Name = "Nome")]
        public String Nome { get; set; }

        [Display(Name = "UF")]
        public String SiglaUF { get; set; }

        [Display(Name = "UF")]
        public virtual UF UF { get; set; }
    }

    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            this.HasKey(t => t.Id);

            this.Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SiglaUF)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(2);

            this.ToTable("CIDADE");

            this.Property(t => t.Id)
                .HasColumnName("COD_CIDADE");

            this.Property(t => t.Nome)
                .HasColumnName("NOME_CIDADE");

            this.Property(t => t.SiglaUF)
                .HasColumnName("SIGLA_UF");

            this.HasRequired(t => t.UF)
                 .WithMany(t => t.Cidades)
                 .HasForeignKey(d => d.SiglaUF);
        }
    }
}