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

        public virtual void Write()
        {
            Console.WriteLine("Hello,write name)");
            string input = Console.ReadLine();
            this.SetName(input);
            Console.WriteLine("Write weight");
            input = Console.ReadLine();
            this.SetWeight(Int32.Parse(input));
            Console.WriteLine("Write age");
            input = Console.ReadLine();
            this.SetAge(Int32.Parse(input));
        }
    };

    class Student : Human
    {
        private int[] marks;
        private string[] subjects;
        private string university_name;
        
        public Student() : base()
        {
            this.marks = new int[5];
            this.university_name = "Default university name";
        }

        public Student(int age, int weight, string name,string univer_name) : base(age,weight,name)
        {
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

        public void SetSubjects(string[] subjects)
        {
            if (subjects != null)
            {
                this.subjects = subjects;
            }
        }
        public string[] GetSubject()
        {
            return this.subjects;
        }

        public string GetSubject(int pos)
        {
            return this.subjects[pos];
        }

        public int[] GetMarks()
        {
            return this.marks;
        }

        public int GetMarks(int pos)
        {
            return this.marks[pos];
        }

        public void Setmarks(int[] mark)
        {
            if(mark != null)
            {
                this.marks = mark;
            }
        }

        public override string Display()
        {
            string output = base.Display();
            output += "\nUniversity name:" + GetUniversityName();
            output += "\nMarks:\n";
            for(int i = 0; i < this.marks.Length; i++)
            {
                output += this.GetSubject(i) + ":" + this.marks[i] + "\n";
            }
            return output;
        }

        public override void Write()
        {
            base.Write();
            Console.WriteLine("\nWrite university name");
            this.SetUniversityName(Console.ReadLine());
            
        }

        public string[] Parse(string input)
        {
            int wordscount = 0;

            for(int i = 0;i < input.Length;i++)
            {
                //Console.WriteLine("Index:" + i);
                //Console.WriteLine("Char:" + input.Substring(i, 1));
                if (input.Substring(i, 1) == " ")
                {
                    wordscount++;
                }
            }
            //Console.WriteLine("wordscount:" + wordscount);
            int[] startpoints = new int[wordscount];
            int[] endpoints = new int[wordscount + 1];
            string[] output = new string[wordscount];
            int x = 1;
            endpoints[0] = 0;
            
            for (int k = 0; k < input.Length; k++)
            {
                if (input.Substring(k, 1) == " ")
                {
                    endpoints[x] = k + 1;
                    //Console.WriteLine("Point:" + k);
                    //Console.WriteLine("Endd:" + endpoints[x]);
                    x++;
                }
            }
            /*
            for(int i = 0; i < endpoints.Length; i++)
            {
                Console.WriteLine("Ended:" + endpoints[i]);
            }
            */
            for(int i = 1;i < wordscount + 1; i++)
            {
                output[i - 1] = input.Substring(endpoints[i-1], endpoints[i] - endpoints[i - 1]);
                //Console.WriteLine("Endpoint:" + endpoints[i - 1]);
                //Console.WriteLine("String:" + output[i - 1]);
            }

            /*for (int i = 0; i < wordscount; i++)
            {
                Console.WriteLine("parsed:" + output[i]);
            }
            */
            return output;
        }
    }



}


