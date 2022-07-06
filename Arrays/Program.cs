using System;

namespace Arrays
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // string student1 = "Neslihan";
            // string student2 = "Gülsüm";
            // string student3 = "Mahmut";

            string[] students = new string[3];
            students[0] = "Neslihan";
            students[1] = "Gülsüm";
            students[2] = "Sevgi";

            string[] students2 = new[] {"Neslihan", "Gülsüm", "Sevgi"}; //2. dizi örneği
            string[] students3 = {"Neslihan", "Gülsüm", "Sevgi"}; //3. dizi örneği

            foreach (var student in students) //1. dizi örneği
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                {"İstanbul", "Balıkesir", "Sakarya"},
                {"Ankara", "Konya", "Kırkkale"},
                {"Düzce", "Bolu", "Kocaeli"},
                {"Rize", "Trabzon", "Sinop"},
                {"Antalya", "İzmir", "Muğla"}
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("***************");
            }

            Console.ReadLine();
        }
    }
}