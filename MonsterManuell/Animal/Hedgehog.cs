using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class Hedgehog : Animal
    {
        public bool ThePeoplesCat {  get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Chrip!");
        }
        public Hedgehog(string name, double weight, int age, bool thePeoplesCat) : base(name, weight, age)
        {
            ThePeoplesCat = thePeoplesCat;
        }

        public override string Stats()
        {
            return $"{GetBaseStats()}, The Peoples Cat: {ThePeoplesCat}";
        }
    }
}
