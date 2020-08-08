using System;
using System.Collections.Generic;
using System.Text;

namespace Csharptest
{
    class Human
    {
        private int age;
        private int weight;
        private string name;

        Human()
        {
            age = 20;
            weight = 70;
            name = "Dodik";
        }

        public Human(int age, int weight, string name)
        {
            SetAge(age);
            SetWeight(weight);
            SetName(name);
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
    }

}
