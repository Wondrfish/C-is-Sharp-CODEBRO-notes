using System;

namespace Myfirsstprogram
{
    class Program
    { 
        static void Main(string[] args)
        {
            int x; //decloration

            x = 123;//intialization

            int y = 321;// decloration + intialization

            int z = x + y;

            int age = 23; // whole ints only
            double height = 300.5;//decimal numbers
            bool alive = true;// true or false
            char symbol = '@';
            string name = "bro";
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("your height is " + height + "cm");
            Console.WriteLine("Are you alilve? " + alive);
            Console.WriteLine("yor symbbol is " + symbol);
            Console.WriteLine("hello "  + name);

            string username = symbol + name;

            Console.WriteLine("ur username is " + username);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);


        }
     }
 
}
