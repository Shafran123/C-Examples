using System;

namespace c_sharp_session1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a  , b , sum; 
            Console.WriteLine("Enter Num 1");
            a =int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter Num 2");
            b =int.Parse(Console.ReadLine()); 
            sum = a + b;
            Console.WriteLine("Sum is , {0} " , sum);  
        }
    }
}
