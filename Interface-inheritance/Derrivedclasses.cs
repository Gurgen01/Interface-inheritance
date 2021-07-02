using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_inheritance
{
    class Baby:Person,ICrier
    {
        public Baby(string name,int age)
        {
            this.name = name;
            this.age = age;
                
        }

        public void Cry()
        {

            Console.WriteLine("I love crying");
        }

        public override void Eat()
        {
            Console.WriteLine("I love milk!!");
        }

        public override void Sleep()
        {
            Console.WriteLine("I  sleep 10-12 hours a day ");
        }
    }
    class Wooman : Person,IWorkable,Ilonghair
    {
        public Wooman(string name,int age)
        {
            this.name = name;
            this.age = age;

        }
        public override void Eat()
        {
            Console.WriteLine("I dont eat fastfood");
        }

        public void Hair()
        {
            Console.WriteLine("my hair are long");
        }

        public override void Sleep()
        {
            Console.WriteLine("I sleep 8 hours a day");
        }

        public void Work()
        {
            Console.WriteLine("I am working 4 hours a day");
        }
    }
    class Man:Person,IWorkable,IStrong
    {
        public Man(string name,int age)
        {
            this.name = name;
            this.age = age;

        }
        public override void Eat()
        {
            Console.WriteLine("I eat a lot");
        }

        public override void Sleep()
        {
            Console.WriteLine("I sleep 6hours a day");
        }

        public void Strong()
        {
            Console.WriteLine("I am strong!!");
        }

        public void Work()
        {
            Console.WriteLine("I work 8 hours a day") ;
        }
    }
}
