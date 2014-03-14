using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTRepository.Models
{
    public interface IPessoaRepository
    {
        IEnumerable<Pessoa> GetAll();
        Pessoa Get(int id = 0);

        void Insert(Pessoa p);
        void Update(Pessoa p);
        void Delete(int id = 0);
    }
}
