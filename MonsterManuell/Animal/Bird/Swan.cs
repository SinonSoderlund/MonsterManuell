using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class Swan : Bird
    {
        public int BodyCount { get; set; }
        public override void DoSound()
        {
            Console.WriteLine(">:|");
        }
        public Swan (string name, double weight, int age, int numberOfTeeth, int bodyCount) : base(name,weight,age,numberOfTeeth)
        {
            BodyCount = bodyCount;
        }

        public override string Stats()
        {
            return $"{GetBaseStats()}, Body count: {BodyCount}";
        }

    }
}
