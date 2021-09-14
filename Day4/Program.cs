using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    interface Iuser
    {
        int a { get; set; }
        void work();
    }
    class User : Iuser
    {
        public int a { get => a;
        set => a = value; }
        public void work()
        {
            throw new NotImplementedException();
        }
    }
    class IndexedClass
    {
        private String[] names = new string[10];

        public string this[int index]
        {
            get
            {
                return (index >= 0 && index <= 9) ? names[index] : "";
            }
            set
            {
                if (index >= 0 && index <= 9)
                {
                    names[index] = value;
                }
            }
        }
        public int this[string name]
        {
            get 
            {
                int index = 0;
                while (index < 10)
                {
                    if (names[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return -1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IndexedClass nameList = new IndexedClass();
            nameList[0] = "Gee";
            nameList[1] = "Heee";
            Console.WriteLine(nameList["Heee"]);
            Console.Read();
        }
    }
}
