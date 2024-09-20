using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class Horse : Animal
    {
        public int NumberOfBlades { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Doth hast invoked death");
        }
        public Horse(string name, double weight, int age, int numberOfBlades) : base (name,weight,age)
        {
            NumberOfBlades = numberOfBlades;
        }

        public override string Stats()
        {
            return $"{GetBaseStats()}, Number of blades: {NumberOfBlades}";
        }
    }
}
