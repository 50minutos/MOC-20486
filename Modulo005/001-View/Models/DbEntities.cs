using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _001_View.Models
{
    public class DbEntities : DbContext
    {
        static DbEntities()
        {
            Database.SetInitializer<DbEntities>(null);
        }

        public DbEntities()
            : base(@"Data Source=(localdb)\v11.0;Initial Catalog=DB;Integrated Security=true;")
        {

        }

        public DbSet<UF> UFs { get; set; }
        public DbSet<Cidade> Cidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new UFMap());
            modelBuilder.Configurations.Add(new CidadeMap());
        }
    }
}