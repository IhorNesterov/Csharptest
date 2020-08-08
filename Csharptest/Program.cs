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
            human.Write();
            student.Write();
            Console.WriteLine(human.Display());
            Console.WriteLine(student.Display());
        }
    }
}
