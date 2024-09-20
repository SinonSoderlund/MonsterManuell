using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class Flamingo : Bird
    {
        public bool Flaming {  get; set; }
        public override void DoSound()
        {
            Console.WriteLine("AAAAAAAA");
        }
        public Flamingo(string name, double weight, int age, int numberOfTeeth, bool flaming) : base (name,weight,age,numberOfTeeth)
        {
            Flaming = flaming;
        }
        public override string Stats()
        {
            return $"{GetBaseStats()}, Flaming: {Flaming}";
        }

    }
}
