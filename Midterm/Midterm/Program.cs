using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {

            // Selection, which is when choosing between two or more alternative paths. These types would be, if, if/else, and switch. 
            // Sequential, is sequential execution of code statements.
            // Repetition is used for creating a loop.For example, while, do/while, and for. 


            //int i = 14;
            //Boolean keepLooping = true;
            //while (keepLooping)
            //{
            //    if (i <= 13)
            //        keepLooping = false;

            //    i++;
            //    Console.WriteLine(i);
            //}



            //int i = 2;

            //while (i <= 128)
            //{
            //    Console.WriteLine(i += 2);
            //}





            //for (; ; )
            //{
            //    for (int i = 50; i > 0; i--)
            //    {
            //        Console.WriteLine("no new lines");
            //    }

            //}


            Console.WriteLine("Odd numbers from 1 to 21. No new lines.");
            for (int j = 1; j < (21 + 1); j++)
            {
                if (j % 2 != 0)
                {
                    Console.WriteLine(j.ToString());
                }
            }



            int n = 8;

            int i = 10; 
            //do
            //{
            //    Console.Write("*");

            //    i++;
            //}
            while (i < n);


            // We combine multiple Boolean values by using || or &&.

            Boolean icyRain = false;
            Boolean tornadoWarning = false;

            if (icyRain && tornadoWarning)
            {
                Console.WriteLine("Lets go outside!");
            }
               





        }




    }
}
