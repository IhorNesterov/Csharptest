
using System;

namespace Csharptest
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human(20, 90, "Igor Nesterov"); //Create new object from class Human
            Console.WriteLine("Hello,write name)");
            string input = Console.ReadLine(); 
            human.SetName(input);
            Console.WriteLine("Write weight");
            input = Console.ReadLine();
            human.SetWeight(Int32.Parse(input));
            Console.WriteLine("Write age");
            input = Console.ReadLine();
            human.SetAge(Int32.Parse(input));
            Console.WriteLine("Name = " + human.GetName());
            Console.WriteLine("Age = " + human.GetAge());
            Console.WriteLine("Weight = " + human.GetWeight());
        }
    }
}
