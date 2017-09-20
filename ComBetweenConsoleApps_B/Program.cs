using System;

namespace App_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Test {DateTime.Now}");
            Console.WriteLine($"Guid {Guid.NewGuid()}");
            Console.WriteLine($"Guid {Guid.NewGuid().GetHashCode()}");
        }
    }

}
