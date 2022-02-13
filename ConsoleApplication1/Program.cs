using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // boolean 1byte
            bool b = true;
            b = false;
            Console.WriteLine("{0}", b);

            // float 4bytes
            float f = 3.14f;

            // double 8bytes
            double d = 3.14;

            // char 2bytes
            char c = 'A';

            // string 
            string s = "Hello";

            Console.WriteLine(s);
        }
    }
}