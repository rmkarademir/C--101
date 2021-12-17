using System;

namespace First_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Adınızı giriniz.");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz.");
            string surname = Console.ReadLine();
            System.Console.WriteLine("Merhaba " + name + " " + surname);
            System.Console.WriteLine("Rüstem Muhammed Karademir");
        }
    }
}
