using PessoaWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PessoaWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicePessoa" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicePessoa.svc or ServicePessoa.svc.cs at the Solution Explorer and start debugging.
    public class ServicePessoa : IServicePessoa
    {
        DBEntities db = new DBEntities();

        public ServicePessoa()
        {
            db.Configuration.LazyLoadingEnabled = false;
        }

        public IEnumerable<Pessoa> Get()
        {
            return new DBEntities().Pessoas;
        }
    }
}
