using System;

namespace Interface_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Man Man = new Man("Edgar", 30);
            Baby Baby = new Baby("John", 1);
            Wooman Wooman = new Wooman("Ariana", 28);
            
            Wooman.Whoareyou();
            Wooman.Work();
            Wooman.Hair();
            Baby.Whoareyou();
            Baby.Cry();
            Baby.Sleep();
            Man.Whoareyou();
            Man.Work();
            Man.Strong();
            
        }
    }
}
