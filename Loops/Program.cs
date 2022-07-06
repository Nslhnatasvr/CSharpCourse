using System;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;

namespace Loops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Döngüleri, veri kümesini dolasmak için kullanırız.
            //sayaç //şart 
            //ForLoop();
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("Now number is {0}", number);
            Console.ReadLine();
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("finished!");
        }
    }
}