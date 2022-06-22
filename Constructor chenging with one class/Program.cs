using System;

namespace Constructor_chenging_with_one_class
{
    class Program
    {
        // this is a constructor overloding  
        Program() : this(20)
        {
            Console.WriteLine("Hello :");
        }
        Program(int x)
        {
            Console.WriteLine("Hiiiiii");
        }
        Program(string x):this()
        {
            Console.WriteLine("Bye ");
        }
        static void Main(string[] args)
        {
            Program obj = new Program("A");
            
        }
    }
}
