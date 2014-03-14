using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace _001_Controller.Models
{
    public class Contexto : DbContext
    {

	static TTContext()
        {
            Database.SetInitializer<TTContext>(null);

        }	

        public Contexto()
            : base(@"Data Source=(localdb)\v11.0;Integrated Security=true;Initial Catalog=DB;")
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Parametro> Parametros { get; set; }
    }
}
