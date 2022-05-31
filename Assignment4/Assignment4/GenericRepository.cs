using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class GenericRepository : IRepository<Id>
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Id entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Id entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Id> IRepository<Id>.GetAll()
        {
            throw new NotImplementedException();
        }

        Id IRepository<Id>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
