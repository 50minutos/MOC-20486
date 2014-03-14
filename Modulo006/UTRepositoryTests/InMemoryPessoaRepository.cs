using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTRepository.Models;

namespace UTRepositoryTests
{
    public class InMemoryPessoaRepository : IPessoaRepository
    {
        List<Pessoa> db = new List<Pessoa>();

        public InMemoryPessoaRepository()
        {
            db.Add(new Pessoa { PessoaId = 1, PessoaNome = "adao" });
            db.Add(new Pessoa { PessoaId = 2, PessoaNome = "eva" });
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return db;
        }

        public Pessoa Get(int id = 0)
        {
            return db.FirstOrDefault(o => o.PessoaId == id);
        }

        public void Insert(Pessoa p)
        {
            db.Add(p);
        }

        public void Update(Pessoa p)
        {
            db[db.IndexOf(Get(p.PessoaId))].PessoaNome = p.PessoaNome;
        }

        public void Delete(int id = 0)
        {
            db.Remove(Get(id));
        }
    }
}
