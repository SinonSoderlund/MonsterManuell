using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class Bird : Animal
    {
        public int NumberOfTeeth { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Chrok");
        }

        public Bird(string name, double weight, int age, int numberOfTeeth) : base(name, weight, age)
        {
            NumberOfTeeth = numberOfTeeth;
        }

        public override string Stats()
        {
            return $"{base.GetBaseStats()}, Number of teeth: {NumberOfTeeth}";
        }

        protected override string GetBaseStats()
        {
            return $"{base.GetBaseStats()}, Number of teeth: {NumberOfTeeth}";
        }
    }
}
