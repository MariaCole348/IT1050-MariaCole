using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Single-selection statement and the while repetition statement are different because an action or a set of actions is based on whether a condition is true or false. However, if the condition is true, the if single-selection statement performs the action once.
            // Whereas the while repetition statement repeatedly performs an action until the condition becomes false. 

            int speed = 42;

            int speedlimit = 35;

            if (speed > speedlimit)
            {
                Console.WriteLine("Slow Down!");
            }
            else
            {
                Console.WriteLine("Speed is acceptable");
            }


            int grade = 40;


            if (grade < 50)
            {
                Console.WriteLine("It is true");
            }
            else
            {
                Console.WriteLine("It is false");
            }


            // Code to read a value: double fahrenheit = Convert.ToDouble(Console.ReadLine()); Code to convert: celsius  = (fahrenheit - 32d) * 5d / 9d;  


            int i = 0;

            while (i <= 10)
            {
               Console.WriteLine(i += 1);
            }
            while (i >= 10)
            {
                Console.WriteLine(i -= 10);
            }



            for (int j = 1; j > 10; j = j + 1)
            {
                Console.WriteLine(j);
            }



            for (int j = 60; j > 20; j = j - 5)
            {
                Console.WriteLine(j);
            }
            

            for (int j = 10; j > 20; j = j + 2)
            {
                Console.WriteLine(j);
            }




        }
    }
}
