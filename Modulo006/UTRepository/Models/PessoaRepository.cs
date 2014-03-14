using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace UTRepository.Models
{
    public class PessoaRepository : IPessoaRepository
    {
        DBEntities db = new DBEntities();

        public IEnumerable<Pessoa> GetAll()
        {
            return db.Pessoas;
        }

        public Pessoa Get(int id = 0)
        {
            return GetAll().FirstOrDefault(o => o.PessoaId == id);
        }

        public void Insert(Pessoa p)
        {
            db.Pessoas.Add(p);
            db.SaveChanges();
        }

        public void Update(Pessoa p)
        {
            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id = 0)
        {
            db.Pessoas.Remove(db.Pessoas.Find(id));
            db.SaveChanges();
        }
    }
}