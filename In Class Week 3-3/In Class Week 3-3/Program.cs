using System;

namespace In_Class_Week_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            // while (i <= 100)
            // {
            //     Console.WriteLine(i += 10);
            // }
            // while (i >= 0)
            // {
            //     Console.WriteLine(i -= 10);
            // }

            //int maxValue;
            //Console.Write("Enter the max value:");
            //maxValue = Convert.ToInt32(Console.ReadLine());


            //Console.Write("Enter the max value:");
            //maxValue = Convert.ToInt32(Console.ReadLine());

            //int i = 0;

            //while (i <= maxValue)
            //{
            //    Console.WriteLine(i);
            //    i += incrementValue;
            //}

            //i -= incrementValue * 2;

            //while (i >= 0)
            //{
            //    Console.WriteLine(i);
            //    i -= incrementValue;
            //}

            //int j = 0;
            //while (j < 100000000)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //    continue;
            //    Console.WriteLine("This is th end of the loop");
            //}

            //int j = 0;
            ////Console.WriteLine(j++);
            ////Console.WriteLine(j);

            //j = 11;
            //while (j > 1)
            //{
            //    Console.Write(j + " ");
            //    Console.Write(j % 2 == 0 ? "even" : "odd");
            //    Console.Write(j == 5 ? ". 5 is my favorite number!" : "");
            //    Console.WriteLine();
            //}

            int i = 1;
            int j = 1;
            int numRows = 6;
            int numCols = 6;

            while (i <= numRows)
            {
                while (++j <= numCols)
                {
                    Console.Write($" {i}, {j}", i, j);
                }
                i++;
                j = 1;
            }


        }
    }
}
