using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class MyList<T>
    {
        public void Add(T element);
        public T Remove(T index);
        public bool Contains(T element);
        public void Clear();
        public void InsertAt(T element, int index);
        public void DeleteAt(int Index);
        public T Find(int index);
    }
}
