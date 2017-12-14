using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using Repository;
using View.ViewModel;

namespace ViewAss
{
    public class PessoaView
    {
        private PessoaController controller;

        public PessoaView(PessoaController cont)
        {
            controller = cont;
        }

        public void Menu()
        {
            int opt = 0;

            switch(opt)
            {
                case 1:
                {
                        PessoaVM pvm = new PessoaVM();

                        controller.SalvarPessoa(pvm);
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            PessoaRepositoryList rep = new PessoaRepositoryList();
            PessoaController cont = new PessoaController(rep);
            PessoaView view = new PessoaView(cont);

            view.Menu();
        }
    }
}
