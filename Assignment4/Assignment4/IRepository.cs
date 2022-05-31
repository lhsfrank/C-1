using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public interface IRepository<T> where T : class
    {
        public void Add(T entity);
        public void Remove(T entity);
        public void Save();
        public IEnumerable<T> GetAll();
        public T GetById(int id);

    }
}
