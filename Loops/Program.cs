using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that prints out the lyrics to the song “99 Bottles of Beer on the Wall”.*/
            for(int i = 99; i>0;i--)
            {
                var songVerse = "{0} bottles of rootbeer on the wall. \r\n{0} bottles of rootbeer.\r\n" +
                    "Take one down and pass it around.\r\n{1} bottles of rootbeer on the wall.\r\n";

                Console.WriteLine(songVerse, i, i - 1);
                Console.WriteLine();
            }

            Console.ReadLine();
            Console.Clear();

            /*Write a program that prints even integers from 0 to 50.*/
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }

            Console.ReadLine();
            Console.Clear();

            /*Use a for statement to print 10 random numbers.*/
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(100));
            }

            Console.ReadLine();
            Console.Clear();

            /*Write a GPA calculator program that takes grade data for a student and prints the resulting GPA. The output should look something like this:
            Your grade (0.0-4.0): 4
            # credits: 3
            Enter another grade? [y/n]: y
            Your grade (0.0-4.0): 4
            # credits: 2
            Enter another grade? [y/n]: n
            Your GPA is: 4.0
            */
            Console.WriteLine("Hello World!");

            Console.ReadLine();
        }
    }
}
