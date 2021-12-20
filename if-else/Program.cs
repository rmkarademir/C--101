using System;

namespace if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            //int time = 19;

            if(time>=22 && time<6)
                System.Console.WriteLine("Gece");
            else if(time>=6 && time<14)
                System.Console.WriteLine("Gündüz");
            else
                System.Console.WriteLine("Puant");

            string vakit = time<12 ? "Öğleden önce" : "Öğleden sonra";
            System.Console.WriteLine(vakit);

            System.Console.WriteLine("Ternary {0}",time>=22 && time<6 ? "Gece" : time>=6 && time<14 ? "Gündüz" : "Puant");
        }
    }
}
