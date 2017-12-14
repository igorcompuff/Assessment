using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Pessoa: ICloneable
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Nascimento { get; set; }

        public Pessoa()
        {
            Id = -1;
        }

        public int GetDaysToBirthday()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            Pessoa p = obj as Pessoa;
            return p != null && p.Id == Id;
        }

        public bool IsValid()
        {
            bool result = true;

            if (Nome.Length > 50 || Sobrenome.Length > 50 || Nascimento == DateTime.MinValue)
            {
                result = false;
            }

            return result;
        }

        public object Clone()
        {
            return new Pessoa() { Nome = this.Nome, Nascimento = this.Nascimento, Sobrenome = this.Sobrenome, Id = this.Id };
        }
    }
}
