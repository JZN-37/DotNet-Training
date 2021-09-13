using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    enum role
    {
        Developer=2, Delivery_Manager=5
    }
    class User
    {
        public role role { get; set; }
        public string name { get; } //read only
        const int age = 20; //instance constant
        public User(string name)
        {
            this.name = name;
            //Console.WriteLine("user");
        }
        public void Enter()
        {
            //Console.WriteLine("user");
        }
    }
    class Employee : User
    {
        public Employee(string name):base(name)
        {
            Console.WriteLine("emp constructor");
        }
        /*
        public static string h="hello";
        static Employee()
        {
            //h = "hello";
            Console.WriteLine("static emp");
        }
        */
        public new void Enter()   //over riding a method,
        {
            Console.WriteLine("employee");
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Josen");
            e1.Enter();
            //Console.WriteLine(Employee.h);
            Console.WriteLine(e1.name);

            e1.role = role.Delivery_Manager;
            Console.WriteLine((int)e1.role);
            string strRole = role.Delivery_Manager.ToString();
            Console.WriteLine(strRole);

            //User u1 = new User();
            //u1.Enter();
            
            Console.Read();
        }
    }
}
