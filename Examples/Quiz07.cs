using System;
namespace c_sharp_session1{
    class Rectangle{
        public double length;
        public double width;
        public double getArea(){
            return length * width;
        }
        public void Display(){
            Console.WriteLine("Length " + length);
            Console.WriteLine("Length " + width);
            Console.WriteLine("Area" + getArea());
        }
    }
    class Program{
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.length = 10;
            r1.width = 4;
            r1.Display();
            Console.ReadLine();
        }
    }
}
