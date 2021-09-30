using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace PairingTest.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            //va a=new [1, 2, 3,[3,[7890, 5],[[5, 6, 8]]],9,[4,8,[905,5]]]
        }

        //public IEquatable<> FooMethod(string fooString)
        //{
        //    while (true)
        //    {
        //     yield  Console.WriteLine($"Hi from FooMethod {fooString}");
        //    }
        //}


        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseStartup<Startup>();
    }
}
