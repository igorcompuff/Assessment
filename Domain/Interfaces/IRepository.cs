using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T obj);
        void Remove(T obj);
        IEnumerable<T> List();
    }
}
