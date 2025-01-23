using System;

namespace FunctionAndAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "My message";
            ProcessText(text, PrintMethod);
        }


        public static void PrintMethod(string textToPrint)
        {
            Console.WriteLine($"---{textToPrint}---");
        }


        public static void NewPrintMethod(string textToPrint)
        {
            Console.WriteLine($"###---{textToPrint}---####");
        }


        static void ProcessText(string text, Action<String> perform)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                perform(text);
            }
        }

    }
}
