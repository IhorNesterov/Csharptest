using System;
using System.ComponentModel.DataAnnotations;

namespace Csharptest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mark = { 3, 3, 4, 5, 4, 5 };
            Human human = new Human(20, 90, "Igor Nesterov"); //Create new object from class Human
            Student student = new Student(19, 60, "True Dolboeb", "Politekh", mark);
            Console.WriteLine("Hello,write name)");
            string input = Console.ReadLine(); 
            human.SetName(input);
            Console.WriteLine("Write weight");
            input = Console.ReadLine();
            human.SetWeight(Int32.Parse(input));
            Console.WriteLine("Write age");
            input = Console.ReadLine();
            human.SetAge(Int32.Parse(input));
            Console.WriteLine(human.Display());
            Console.WriteLine(student.Display());
        }
    }
}
