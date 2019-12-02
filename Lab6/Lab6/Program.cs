using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.) p[0], p[1], p[2], and p[3].
            // 3.)

            string[] month = new string[12];
            month[0] = "January";
            month[1] = "Febuary";
            month[2] = "March";
            month[3] = "April";
            month[4] = "May";
            month[5] = "June";
            month[6] = "July";
            month[7] = "August";
            month[8] = "September";
            month[9] = "October";
            month[10] = "November";
            month[11] = "December";

            ////4.)
            string[] season = { "Fall", "Spring", "Summer", "Winter" };

            for (int i = 0; i < month.Length; i++)
            {
                Console.WriteLine(month[i]);
            }

            foreach (string season in season) ;

            //5.)

            int[] randomNumber = new int[1000];
            Random random = new Random();

            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(0, 100);
            }

            foreach (int i in randomNumber)
            {
                Console.WriteLine(i.ToString());
            }

            // #6 - 7


            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
                Console.WriteLine("{0,2}. {1}", i, names[i]);
            }









        }
    }
}
