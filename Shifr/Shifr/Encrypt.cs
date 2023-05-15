using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifr
{
    internal class Encrypt
    {
        public delegate char StartEncruptSymbol(char symbol);
        private StartEncruptSymbol encruptSymbol;
       
        public string name { get; private set; }
        
        public Encrypt(StartEncruptSymbol typeEncrypt, char key,string name)
        {
            this.encruptSymbol = typeEncrypt;
            this.key = key;
            this.name = name;
        }
        
        public char GetEncruptSymbol(char symbol) {

            return this.encruptSymbol(symbol);
        }
        public char key { get; private set; }


    }
}
