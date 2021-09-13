using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    class Calculator
    {
        public int num1, num2;
        public Calculator(int v1, int v2)
        {
            num1 = v1;
            num2 = v2;
        }

        public static Calculator operator -(Calculator c1)
        {
            c1.num1 = -c1.num1;
            c1.num2 = -c1.num2;
            return c1;
        }
        public void print()
        {
            Console.WriteLine(num1.ToString()+" , "+num2.ToString());
        }
    }
    class OperatorOverload
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator(15, -25);
            calc = -calc;
            calc.print();
            Console.Read();
        }
    }
}
