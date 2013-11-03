using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Contracts
{
    public interface ICrudController<T> where T : class
    {
        IEnumerable<T> Get();

        T Get(int id);

        void Post(T value);

        void Put(int id, T value);

        void Delete(int id);
    }
}
