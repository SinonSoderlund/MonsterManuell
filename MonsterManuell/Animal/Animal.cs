using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public abstract void DoSound();

        public Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract string Stats();


        protected virtual string GetBaseStats()
        {
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}";
        }

    }
}
