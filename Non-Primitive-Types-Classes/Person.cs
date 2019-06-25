using System;

namespace Non_Primitive_Types_Classes
{
    /// <summary>
    ///  Classes are building-blocks our application. 
    ///  These class combines related variables(fields) and functions(Methods) 
    ///  An object is an instance of a class. 
    ///  At runtime, many objects collaborate with each other to provide some functionality. 
    ///  As a metaphor, think of a supermarket.At a supermarket, there are multiple people working together to provide services to customers.
    ///  Each person has a role and is focused only on one area of functionality.
    ///  Software is exactly the same.
    ///  A role in a supermarket is like a class in a C# application. 
    ///  A person filling that role during work hours, is like an object in an application at runtime.
    /// </summary>
    
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            // WriteLine is a static method, no need to create Console class object in the class
            Console.WriteLine("My name is " + FirstName + " " + LastName );
            Console.ReadKey();
        }
    }
}
