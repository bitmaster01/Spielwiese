using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
           // string s = "das ist ein String";
            Type type = i.GetType();
            Console.WriteLine(type);
            Console.WriteLine("Hello World!");
        }
    }
}
