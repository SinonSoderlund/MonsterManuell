using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class WolfMan: Wolf, IPerson
    {
        public override void DoSound()
        {
            Console.WriteLine("AWooo!");
        }
        public void Talk()
        {
            Console.WriteLine("Helo");
        }
        public WolfMan(string name, double weight, int age, double lenghtOfTeeth): base(name,weight, age, lenghtOfTeeth)
        {

        }
    }
}
