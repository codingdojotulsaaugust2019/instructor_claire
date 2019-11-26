using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanBeing bob = new HumanBeing("Claire");
            HumanBeing josh = new HumanBeing("Josh");
            bob.Attack(josh);
            Console.WriteLine(josh.Health);
            Console.WriteLine("Hello World!");
        }
    }
}
