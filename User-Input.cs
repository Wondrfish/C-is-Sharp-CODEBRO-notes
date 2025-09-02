using System;

namespace Myfirsstprogram
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            String name = Console.ReadLine();

            Console.WriteLine("whats your age ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + $" your {age} years old");
            Console.WriteLine($"soon you will be {age + 1}");
            


        }
     }
 
}
