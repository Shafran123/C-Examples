using System;
namespace c_sharp_session1{
    class Rectangle{
        private double length;
        private double width;

        public void getDetails(){
            Console.WriteLine("Enter Length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width");
            width = Convert.ToDouble(Console.ReadLine());
        }
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
            r1.getDetails();
            r1.Display();
            Console.ReadLine();
        }
    }
}
