using System;

namespace TypesAndVeriables
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");

            

            int number = 1456456450; //32 bitlik yer kaplar
            long number2 = 1456456450; //19 karakter sayı ile sınırlıdır. //64bitlik yer kaplar
            short number3 = -32768; //16 bitlik yer kaplar
            byte number4 = 255; //0'la 255 arası bir değer tutar. //1 bytelık yer kaplar.
            double number5 = 10.4; //ondalıklı sayılarımı tutabiliriz. örnk: 10.4
            decimal number6 = 10.4m;
            bool condition = true; // şart bloğu, değer tip
            char character = 'A';
            string city = "Ankara";


            Console.WriteLine(" Number one is {0}", number);
            Console.WriteLine(" Number two is {0}", number2);
            Console.WriteLine(" Number three is {0}", number3);
            Console.WriteLine(" Number four is {0}", number4);
            Console.WriteLine(" Number five is {0}", number5);
            Console.WriteLine("City is : {0}",city);
            Console.WriteLine("Character is : {0}", character);
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}