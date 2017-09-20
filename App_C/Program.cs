using App_D;
using System;
using System.Threading.Tasks;

namespace App_C
{
    class Program
    {
        static void Main(string[] args)
        {
            UWebAPIClient.Init(ip: "192.168.189.34", appName: "App_D_WebAPI");

            Person p = UWebAPIClient.GetObjectAsync<Person>().Result;
            Dog d = UWebAPIClient.GetObjectAsync<Dog>().Result;

            Task.WaitAll();
            Console.WriteLine(p);
            Console.WriteLine();
            Console.WriteLine(d);
            Console.ReadLine();

        }

    }
}
