using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Primitive_Types_Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            // To create an object, we use the new operator:
            // We use the new operator to allocate memory to an object. In C# you don’t have to worry about de - allocating the memory. 
            // CLR has a component called Garbage Collector, which automatically removes unused objects from memory.
            var person = new Person();

           // Once we have an object, we can access its fields and methods with the dot notation
            person.FirstName = "Abdul";
            person.LastName = "Waqar";
            person.Introduce();
        }
    }
}
