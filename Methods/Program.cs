using System;
using System.Linq;

namespace Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            var result = Add2(20, 30);
            Console.WriteLine(result);
            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add4( int number,params int [] numbers)
        {
            return numbers.Sum();
        }
    }
}