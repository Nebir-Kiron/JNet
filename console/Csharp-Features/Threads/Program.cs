using System;
using System.IO;
using System.Threading;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var thread1 = new Thread(WriteFile);
            var thread2 = new Thread(new ThreadStart(WriteFile));



            thread1.Start();
            thread2.Start();


        }

        

        static void PrintNumbers() 
        {
            for (int i = 0; i < 50; i=i+2)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
                
            }
        }

        static void PrintNumbers2()
        {
            for (int i = 1; i < 51; i= i+2)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        } 

        public static void WriteFile() 
        {
            var path = @"D:\file\File.txt";

            lock (path)
            {
                File.WriteAllText(path, "Hello");
            }
            
        }

    }
}
