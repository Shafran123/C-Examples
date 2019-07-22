using System;
namespace c_sharp_session1{
    class Program{
        static void Main(string[] args)
        {
                int [] array = new int[10];

                for(int i = 0 ; i <10 ; i++){
                    array[i] = i + 10;
                }

                for(int x = 0 ; x < 10 ; x++){
                    Console.WriteLine("Element " + x +" = " + array[x]);
                }
        }
    }
}
