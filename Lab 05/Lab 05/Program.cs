using System;

namespace Lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";

            // To do: uncomment the following lines of code to call the methods
            myDog.bark();
            myDog.doTrick("Fetch");
        }


        // 2.)
        // Scope: 
        // Static vs.Non-Static: this determines if whether I can call it from the same file as Main method or without creating an object.
        // You call any static method by specifying the name of the class in which the method is declared, followed by the member access (.) operater and the method name. 
        // Return Type: this determines the type of value returned and it uses void to indicate no return value. Ex.) Return Type --> double
        // Method Name(Identifier): this describes the name of the user defined method by which the user calls it or refer it Ex.) Method Name --> GetArea()
        // Parameters: name and type of parameters. Parameters are only accessible in the method body.
        // Method Body: This refers to the line of code of tasks to be performed by the method during its execution. It is enclosed between braces.

        // 3.)
        // A user-defined method is like a structure or a record type in other languages. When a class is defined, you specify its name, its direct superclasses, and then its slots. A slot has a name and a type. Usually, each instance stores its own value for the slot. A class inherits the slots defined by its superclasses, and it can define more slots if it needs them.
        // The difference between a static and non-static method is that a static method belongs to the class itself and a non-static method belongs to each object that is generated from that class. Also, you want to make your method static if it does something that doesn't depend on the individual characteristics of its class.



    }
}
