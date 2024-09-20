using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class Dog : Animal
    {
        public int Unpleasantness { get; set; }

        public Dog(string name, double weight, int age,int unpleasantness): base(name,weight,age)
        {
            Unpleasantness = unpleasantness;
        }

        public override void DoSound()
        {
            Console.WriteLine("arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! arf! ");
        }

        public override string Stats()
        {
            return $"{GetBaseStats()}, Unpleasantness: {Unpleasantness}";
        }

        public string arf(string arff)
        {
            return arff; 
        }

    }
}
