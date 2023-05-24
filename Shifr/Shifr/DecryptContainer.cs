using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shifr
{
    internal class DecryptContainer
    {

        public List<DecryptProccesor> decryptProccesors { get; private set; } = new List<DecryptProccesor>();
        string key;
        public DecryptContainer(string key) {
        this.key = key;
            Load();
        }
        
        private void Load()
        {
            
            foreach (char item in key)
            {
                switch (item)
                {
                    case 'I':
                        decryptProccesors.Add(new Inc());
                        break;
                    case 'D':
                        decryptProccesors.Add(new Dec());break;
                    case 'Z':decryptProccesors.Add(new Zero());break;
                    case 'S':decryptProccesors.Add(new Sub());break;    

                }
            }
        
            
        }
    }
}
