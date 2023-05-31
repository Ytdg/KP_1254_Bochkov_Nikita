using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tests
{
   
    internal class TestResult
    {
        public delegate void serializeDelegat(TestResult obj);
    
        public string NameUser { get; set; }
        public string LastUser {get;set;}
        public int YearsUser { get; set; }
        public string GroupUser { get; set; }
        public string Answer1 { get; set; }
        public List<string> Answer2 { get; set; } = new List<string>();
        public string Answer3 { get; set; }
        public decimal Answer4 { get; set; }
        public string Answer5 { get; set; }
       
        public serializeDelegat serializeDel { private get; set; }
        

        public void Serialize()
        {
            serializeDel(this);

        }
      
    }
}
