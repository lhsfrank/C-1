using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.ColorBall
{
    public class Ball
    {
        Color c = new Color(1, 2, 3);
        public int Size { get; set; }
        public int NumOfTh { get; set; }

        public Ball (Color c, int size, int numOfTh)
        {
            this.c = c;
            Size = size;
            NumOfTh = numOfTh;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size != 0)
                NumOfTh++;
        }

        public int NumOfTimesThrown()
        {
            return NumOfTh;
        }
    }
}
