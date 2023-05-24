using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifr
{
    internal class Sub: DecryptProccesor
    {
        public override char Process(char symbol)
        {
       
            char str = (char)(255 - (int)symbol);
            return Convert.ToChar(str);
        }
    }
}
