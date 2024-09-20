using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class DroidError : UserError
    {
        public override string UEMessage()
        {
            return "These are not the droids you are looking for";
        }
    }
}
