﻿using System;

namespace Strings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Neslihan";
            var result = sentence.Length;
            var result2 = sentence.Clone();

            bool result3 = sentence.EndsWith("n");
            bool result4 = sentence.StartsWith("My Name");

            var result5 = sentence.IndexOf("namee");
            var result6 = sentence.IndexOf("");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0,"Hello,  ");
            var result9 = sentence.Substring(3);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace("","");
            var result13 = sentence.Remove(2);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            string result = city + " " + city2;

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}