using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifr
{
    internal class Decryptor
    {   
        public string Decrypt(string key, string textToDecrypt)
        {
            string result="";
            DecryptContainer container = new DecryptContainer(key);
            int index = 0;
            foreach (char symbol in textToDecrypt)
            {
                if(index == container.decryptProccesors.Count) { index = 0; }
                result += container.decryptProccesors[index].Process(symbol);
                index++;
            }
            return result;

            
        }
    }
}
