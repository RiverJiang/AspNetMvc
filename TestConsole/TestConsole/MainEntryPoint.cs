using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class MainEntryPoint
    {
        static void Main()
        {
            // Try calling some static functions
            Console.WriteLine("PI is " + MathTest.GetPi());
            int x = MathTest.GetSquareOf(5);
            Console.WriteLine("Square of 5 is " + x);

            //Instantiate a MathTest object
            //this is C#'s way of instantiating a reference type.
            MathTest math = new MathTest(); 

            // Call nonstatic methods
            math.value = 30;
            Console.WriteLine("Value field of math variable contains " + math.value);
            Console.WriteLine("Square of 30 is " + math.GetSquare());
        }
    }

    class MathTest
    {
        private const double PI = 3.1415;

        internal static double GetPi()
        {
            return PI;
        }

        internal static int GetSquareOf(int x)
        {
            return x * x;
        }

        internal int GetSquare()
        {
            return value * value;
        }

        public int value { get; set; }
    }
}
