using System;

namespace Overflowing
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                byte number = 255;
                Console.WriteLine(number);

            }

            Console.ReadKey();
        }
    }
}
