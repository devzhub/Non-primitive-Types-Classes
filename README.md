# Non-primitive-Types-Classes
Classes

Classes are building-blocks our application. 
These class combines related variables(fields) and functions(Methods) 
An object is an instance of a class. 
At runtime, many objects collaborate with each other to provide some functionality. 
As a metaphor, think of a supermarket.At a supermarket, there are multiple people working together to provide services to customers.
Each person has a role and is focused only on one area of functionality.
Software is exactly the same.
A role in a supermarket is like a class in a C# application. 
A person filling that role during work hours, is like an object in an application at runtime.

WriteLine is a static method, no need to create Console class object in the class

To create an object, we use the new operator
We use the new operator to allocate memory to an object. 
In C# you don’t have to worry about de-allocating the memory. 
CLR has a component called Garbage Collector, which automatically removes unused objects from memory.

Once we have an object, we can access its fields and methods with the dot notation
