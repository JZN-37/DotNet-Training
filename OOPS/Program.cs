using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Shape()
        {
            Console.WriteLine("Super Constructor is Called");
        }
    }
    class Triangle : Shape
    {
        string kind;
        static long DateofCreation;
        static Triangle()
        {
            DateofCreation = DateTime.Now.Ticks;
            Console.WriteLine("Called Once");
        }
        public Triangle(int Width1, int v2):this(Width1)
        {
            Width = Width1;
            Height = v2;
        }
        public Triangle(double Width1) : base()
        {
            //this.Width = Width;
            this.Width = Width1;
        }
        /*
        private Triangle(double area)
        {
            
        }
        */
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(10,20);
            Shape t2 = t1;
            Console.WriteLine(t1 == t2);
            //new Triangle(); //cant create object using static constructor
            Triangle t3 = new Triangle(50.7);
            Console.WriteLine(t3.Width);
            Console.Read();
        }
    }
}
