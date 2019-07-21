using System;

namespace c_sharp_session1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("Enter Your Name");
            x = Console.ReadLine();
            Console.WriteLine("Hi " + x  + " How Are You?"); //Type 01
            Console.WriteLine("Hi , {0}  How Are You?" , x);    //Type 02
        }
    }
}
