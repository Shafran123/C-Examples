using System;
namespace c_sharp_session1{
    class Shape{
        public void setWidth(int w){
            width = w;
        }
        public void setHeight(int h){
            height = h;
        }
        protected int width;
        protected int height;
    }

    class Rectangle:Shape{
        public int getArea(){
            return (width*height);
        }
    }

    class Program{
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.setWidth(10);
            r1.setHeight(4);

            Console.WriteLine("Total Area is " + r1.getArea());
            Console.ReadLine();
        }
    }
}
