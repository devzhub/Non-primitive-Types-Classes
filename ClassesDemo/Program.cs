using ClassesDemo.Maths;
using System;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FirstName = "Developerz";
            person.LastName = "Hub";
            person.introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(2, 3);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
