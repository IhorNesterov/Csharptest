using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Csharptest
{
    public class Human
    {
        private int age;
        private int weight;
        private string name;
        public static int count;
        public static int id;

        public Human()
        {
            id = count;
            age = 20;
            weight = 70;
            name = "Dodik";
            count++;
        }

        public Human(int age, int weight, string name)
        {
            id = count;
            SetAge(age);
            SetWeight(weight);
            SetName(name);
            count++;
        }

        public void SetAge(int age)
        {
            if (age > 0 && age < 150)
            {
                this.age = age;
            }
        }
        public int GetAge()
        {
            return age;
        }

        public void SetWeight(int weight)
        {
            if (weight > 10 && age < 400)
            {
                this.weight = weight;
            }
        }
        public int GetWeight()
        {
            return weight;
        }

        public void SetName(string name)
        {
            if (name != null)
            {
                this.name = name;
            }
        }
        public string GetName()
        {
            return name;
        }

        public virtual string Display()
        {
            string output = "";
            output += "Name: " + this.GetName();
            output += "\nAge: " + this.GetAge();
            output += "\nWeight: " + this.GetWeight();
            return output;
        }
    };

    class Student : Human
    {
        private int[] marks;
        private string university_name;
        
        public Student() : base()
        {
            this.marks = new int[5];
            this.university_name = "Default university name";
        }

        public Student(int age, int weight, string name,string univer_name,int[] mark) : base(age,weight,name)
        {
            if (mark != null)
            {
                this.marks = mark;
            }

            if (univer_name != null)
            {
                this.university_name = univer_name;
            }
        }

        public void SetUniversityName(string univer_name)
        {
            if (univer_name != null)
            {
                this.university_name = univer_name;
            }
        }
        public string GetUniversityName()
        {
            return this.university_name;
        }

        public override string Display()
        {
            string output = base.Display();
            output += "\nUniversity name:" + GetUniversityName();
            output += "\nMarks:\n";
            for(int i = 0; i < this.marks.Length; i++)
            {
                output += this.marks[i] + "\n";
            }
            return output;
        }

    }
}


