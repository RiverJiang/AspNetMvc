using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal i = 940.23m;
            decimal j = 73.7m;

            Console.WriteLine("{0,9:C2}\n+{1,9:C2}\n------------\n  {2,9:C2}",i,j,i+j);
        }
    }
}
