using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalProfiler
{
    public static class Utility
    {
        public static void WriteHeading(string message)
        {
            if (string.IsNullOrEmpty(message))
                return;

            var length = message.Length;

            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine(new string('=', length));
            Console.WriteLine();
        }

        public static void WriteSubHeading(string message)
        {
            if (string.IsNullOrEmpty(message))
                return;

            var length = message.Length;

            Console.WriteLine(message);
            Console.WriteLine(new string('-', length));
        }
    }
}
