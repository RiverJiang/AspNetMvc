using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    public class UserPreferences
    {
        public static readonly Color BackColor;

        static UserPreferences()
        {
            DateTime now = DateTime.Now;

            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                BackColor = Color.Green;
            }
            else
            {
                BackColor = Color.Red;
            }
        }

        private UserPreferences()
        {
        }
    }
}
