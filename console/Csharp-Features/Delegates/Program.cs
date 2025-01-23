using System;

namespace Delegates
{
    internal class Program
    {


        delegate void Perform(string text);

        static void Main(string[] args)
        {
            var printer  = new Printer();
            var logic = new Perform(printer.PrintFormat2);
            var text = "My message";
            ProcessText(text, logic);


        }


         public static void PrintMethod(string textToPrint) 
        {
            Console.WriteLine($"---{textToPrint}---");
        }


        public static void NewPrintMethod(string textToPrint)
        {
            Console.WriteLine($"###---{textToPrint}---####");
        }


        static void ProcessText(string text , Perform perform) 
        {
            if (!string.IsNullOrWhiteSpace(text)) 
            {
                perform(text);
            }
        }
    }
}
