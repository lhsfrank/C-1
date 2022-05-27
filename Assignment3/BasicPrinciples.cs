using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public abstract class Gamer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Game { get; set; }

        public abstract void GamingDevice();
    }

    public class ProGamer : Gamer
    {
        public string Sponsor { get; set; }

        public override void GamingDevice()
        {
            Console.WriteLine("They are using Logitech");
        }
    }

    public class RegGamer
    {
        public void Description()
        {
            Console.WriteLine("RegGamer play for fun");
        }
        public void Description(string s)
        {
            Console.WriteLine($"RegGamer is not {s}");
        }

    }
}
