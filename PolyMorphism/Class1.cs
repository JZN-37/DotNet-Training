using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    class RefAndOutDemo
    {
        public static void Main(string[] values)
        {
            //OutDemo();
            RefDemo();
            Console.Read();
        }

        public static void RefDemo()
        {
            string str1 = "Geo";
            SetValue(ref str1);
            Console.WriteLine(str1);
        }
        static void SetValue(ref string str)
        {
            str = "JOoo";
        }


        public static void OutDemo()
        {
            int result;
            Add(out result);
            Console.WriteLine(result);
        }
        public static bool Add(out int a)
        {
            a = 20;
            a = a + a;
            return true;
        }      
    }
}
