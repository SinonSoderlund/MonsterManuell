using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class Pelican : Bird
    {
        public int Long {  get; set; }
        public override void DoSound()
        {
            Console.WriteLine("KAKA!");
        }
        public Pelican(string name, double weight, int age, int numberOfTeeth, int lONG) : base(name, weight, age, numberOfTeeth)
        {
            Long = lONG;
        }
        public override string Stats()
        {
            return $"{GetBaseStats()}, Long: {Long}";
        }

    }
}
