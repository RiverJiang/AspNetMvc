using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class ParameterTest
    {
        static void SomeFunction(int[] ints, int i,string immutableString)
        {
            ints[0] = 100;
            i = 100;
            immutableString = "hello world changed!";
        }

        public static int Main()
        {
            int i = 0;
            int[] ints = { 0,1,2,4,8};
            string immutableString = "Hello World";

            Console.WriteLine("i = " + i);
            Console.WriteLine("ints[0] = " + ints[0]);
            Console.WriteLine("Calling Some Function.");
            Console.WriteLine("string is a immutable reference type. Say \"" + immutableString+ "\".");

            // After the method returns, ints will be changed,but i will not.
            SomeFunction(ints,i,immutableString);
            Console.WriteLine("i = " + i);
            Console.WriteLine("ints[0] = " + ints[0]);
            Console.WriteLine("string is a immutable reference type. Say \"" + immutableString + "\" all the same.");

            return 0;
        }
    }
}
