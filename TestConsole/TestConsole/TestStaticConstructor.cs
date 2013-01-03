using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class TestStaticConstructor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User-preferences: BackColor is: " + UserPreferences.BackColor.ToString());
        }
    }
}
