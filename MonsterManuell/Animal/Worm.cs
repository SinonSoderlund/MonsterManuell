using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class Worm : Animal
    {
        public Worm _Worm {  get; set; }
        public override void DoSound()
        {
            Console.WriteLine("");
        }
        public Worm(string name, double weight, int age): base(name, weight, age) 
        {
            _Worm = this;
        }

        public override string Stats()
        {
            return $"{GetBaseStats()}, Worm: {_Worm}";
        }
    }
}
