using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Contracts
{
    /// <summary>
    /// Represent Create, Read, Update, Delete actions
    /// </summary>
    /// <typeparam name="T">Type of entity for this actions</typeparam>
    public interface ICrud<T> where T : class
    {
        IEnumerable<T> Get();

        T Get(int id);

        void Post(T value);

        void Put(T value);

        void Delete(int id);
    }
}
