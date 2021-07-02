using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_inheritance
{
    abstract class Person
    {
        public string name { get; set; }
         public int age { get; set; }
        public abstract void Eat();
        public abstract void Sleep();
        public  void Whoareyou()
        {
            Console.WriteLine("Hello my name is {0}, my age is {1}",name,age);
        }
     
         

    }
}
