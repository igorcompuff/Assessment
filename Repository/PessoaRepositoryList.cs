using Domain;
using Domain.Interfaces;
using System.Collections.Generic;

namespace Repository
{
    public class PessoaRepositoryList : IRepository<Pessoa>
    {
        private List<Pessoa> pessoas = new List<Pessoa>();

        public void Add(Pessoa obj)
        {
            if (obj.Id < 0)
            {
                pessoas.Add(obj);
            }
            else
            {
                int index = pessoas.IndexOf(obj);
                pessoas[index] = obj;
            }
        }

        public IEnumerable<Pessoa> List()
        {
            List<Pessoa> novaLista = new List<Pessoa>();
            novaLista.AddRange(pessoas);
            return novaLista;
        }

        public void Remove(Pessoa obj)
        {
            pessoas.Remove(obj);
        }

        public Pessoa GetById(long id)
        {
            return pessoas.Find(p => p.Id == id);
        }
    }
}
