using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifr
{
    internal class Zero: DecryptProccesor
    {
      

        public override char Process(char symbol)
        {
            return symbol;
        }
    }
}
