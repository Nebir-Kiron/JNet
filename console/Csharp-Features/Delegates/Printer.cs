using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Printer
    {
        public void PrintFormat1(string textToPrint) 
        {
            Console.WriteLine($"---{textToPrint}---");
        }

        public void PrintFormat2(string textToPrint)
        {
            Console.WriteLine($"###---{textToPrint}---####");
        }

    }
}
