using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                //type of Explicit
                var f = 10000.0f;
                var i = (int)f;
                Console.WriteLine(i);
            }

            checked
            {
                //type of implicit
                int i = 4;
                byte b = (byte)i;
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
