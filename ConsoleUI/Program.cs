using DemoLibrary.DVD;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IBorrowableDVD dvd = new DVD();


            Console.WriteLine("Done.");

            Console.ReadLine();
        }
    }
}
