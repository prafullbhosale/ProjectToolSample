using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_inside_man
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello from inside man!!");
            int i = 0;
            foreach (var arg in args)
            {
                Console.WriteLine($"Arg[{i++}] :: {arg}");
            }
        }
    }
}
