using System;

namespace c_sharp_session1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; 
            Console.WriteLine("Enter Number");
            a =int.Parse(Console.ReadLine()); 

            if (a<100){
                Console.WriteLine("Number is Less than 100");
            }else{
                Console.WriteLine("Number is Greater than 100");
            }
            
            
        }
    }
}
