using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class Wolf : Animal
    {
        public double TeethLenght { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Awoo");
        }

        public Wolf(string name, double weight, int age ,double teethLenght) : base(name, weight, age)
        {
            TeethLenght = teethLenght;
        }
        public override string Stats()
        {
            return $"{GetBaseStats()}, Teeth Lenght: {TeethLenght}";
        }
    }
}
