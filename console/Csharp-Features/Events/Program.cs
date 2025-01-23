using System;

namespace Events
{
    internal class Program
    {

        public delegate void Notify(string address , string message);
        public event Notify notification; 

        static void Main(string[] args)
        {
            var instance  = new Program();
            instance.notification += EmailNotification;
            instance.notification += SMSNotification;
            instance.notification("kironnibir046@gmail.com", "hello");

            instance.notification -= SMSNotification;
            instance.notification("kironnibir046@gmail.com", "hello");
        }

        private static void EmailNotification(string address, string message)
        {
            Console.WriteLine($"Sending email to {address} and message to {message}");
        }

        private static void SMSNotification(string Phonenumber, string message)
        {
            Console.WriteLine($"Sending email to {Phonenumber} and message to {message}");
        }
    }
}
