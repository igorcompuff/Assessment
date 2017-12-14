using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.ViewModel;
using Domain;
using Domain.Interfaces;

namespace Controller
{
    public class PessoaController
    {
        private IRepository<Pessoa> rep;

        public PessoaController(IRepository<Pessoa> rep)
        {
            this.rep = rep;
        }
        public void SalvarPessoa(PessoaVM p)
        {
            var pessoa = new Pessoa();

            pessoa.Nome = p.Nome;
            pessoa.Sobrenome = p.Sobrenome;
            try
            {
                pessoa.Nascimento = DateTime.Parse(p.Nascimento);
            }
            catch(Exception ex)
            {
                pessoa.Nascimento = DateTime.MinValue;
            }

            if (pessoa.IsValid())
            {
                rep.Add(pessoa);
            }
        }

        void AlterarPessoa(PessoaVM p)
        {
            var pessoa = new Pessoa();

            pessoa.Id = p.Id;
            pessoa.Nome = p.Nome;
            pessoa.Sobrenome = p.Sobrenome;
            try
            {
                pessoa.Nascimento = DateTime.Parse(p.Nascimento);
            }
            catch (Exception ex)
            {
                pessoa.Nascimento = DateTime.MinValue;
            }

            if (pessoa.IsValid())
            {
                rep.Add(pessoa);
            }
        }
    }
}
