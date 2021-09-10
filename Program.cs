using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void TakeInputandCalculate()
        {
            Console.Write("Enter the First Number :");
            string a = Console.ReadLine();
            Console.Write("Enter the Second Number :");
            string b = Console.ReadLine();
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);

            Console.WriteLine("The Sum is : {0}",c + d);

        }
        static void Main(string[] args)
        {
            TakeInputandCalculate();
            Console.Read();
        }
    }
}
