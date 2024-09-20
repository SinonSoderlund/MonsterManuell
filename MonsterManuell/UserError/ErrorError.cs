using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class ErrorError : UserError
    {
        public override string UEMessage()
        {
            return "Warning! wrong error!";
        }
    }
}
