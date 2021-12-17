using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "20";
            int int1 = 20;
            string str2 = str1 + int1.ToString();//Çıktı 2020
            Console.WriteLine(str2);

            int int2 = int1 + int.Parse(str1);
            Console.WriteLine(int2);//Çıktı 40
            int int3 = int1 + Convert.ToInt32(str1);
            Console.WriteLine(int3);//Çıktı 40

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(dateTime);
            string dateTime2 = DateTime.Now.ToString("dd-MM-yy");
            System.Console.WriteLine(dateTime2);
            string dateTime3 = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(dateTime3);
            string dateTime4 = DateTime.Now.ToString("HH:mm:ss");
            System.Console.WriteLine(dateTime4);

        }
    }
}
