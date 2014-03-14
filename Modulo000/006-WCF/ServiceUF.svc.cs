using PessoaWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PessoaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceUF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceUF.svc or ServiceUF.svc.cs at the Solution Explorer and start debugging.
    public class ServiceUF : IServiceUF
    {
        DBEntities db = new DBEntities();

        public ServiceUF()
        {
            db.Configuration.LazyLoadingEnabled = false;
        }

        public IEnumerable<UF> Get()
        {
            var lista = db.UFs.ToList<UF>();

            return lista;
        }
    }
}
