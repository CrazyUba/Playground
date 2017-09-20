using System;
using Utility;

namespace App_A
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = ProcessRunner.RunSync("App_B", args);
            Console.WriteLine(data);

        }
    }


}
