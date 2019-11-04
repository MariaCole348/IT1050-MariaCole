using System;

namespace InClass2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string name = "Naddie";
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("hello,{0} {1} {2}!'", name, "Christi", "Maria");
            Console.WriteLine($"hello, {name}!");

            int a = 123;
            int b = 234;
            int sum = a + b;
            Console.WriteLine($"Sum of {a} + {b} = {sum}");


            if (a == a)
            {
                Console.WriteLine("a is greater!");
            }



            //bool case1 = 100 <= 100;
            //bool case2 = 10 > 11;

            //Console.WriteLine(case1);
            //Console.WriteLine(case2);
            //Console.WriteLine(case1 || case2);






        }
    }
}
