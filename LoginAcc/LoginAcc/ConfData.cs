using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAcc
{
    internal static class ConfData
    {
        static public string basicDatapath { get; } = Directory.GetCurrentDirectory() + "\\basicDatta.txt";
        static public string secondaryDatapath { get; } = Directory.GetCurrentDirectory() + "\\secondaryDatta.txt";
        

       
    }
}
