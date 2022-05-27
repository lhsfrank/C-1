using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public interface IPersonService
    {
        int Age(int num);
        //{
        //    return num;
        //}
        decimal Salary(decimal sal)
        {
            if (sal >= 0)
                return Salary(sal);
            else
                return 0;
        }
        String Address(string str)
        {
            return str;
        }
    }

}
