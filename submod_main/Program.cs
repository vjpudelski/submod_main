using System;

namespace submod_main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(submod_class.Math.Add(1, 4));

            Console.WriteLine(submod_class.Math.Subtract(5,2));

            Console.WriteLine(submod_class.Math.Multiply(5,2));
        }
    }
}
