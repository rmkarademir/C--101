using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //      System.Console.WriteLine("Bir sayi giriniz:");
            //      int sayi = Convert.ToInt32(System.Console.ReadLine());
            //      System.Console.WriteLine("Girilen sayi: " + sayi);
            // }
            // catch (Exception ex)
            // {
            //     System.Console.WriteLine("Hata: " + ex.Message.ToString());
            // }
            // finally
            // {
            //     System.Console.WriteLine("işlem tamamlandı.");
            // }

            try
            {
                 //int a = int.Parse(null);
                 //int a = int.Parse("sayi");
                 int a = int.Parse("-123456789101");
                 
            }
            catch (ArgumentNullException ex)
            {
                System.Console.WriteLine("Hata1: Boş değer girdiniz.");
                System.Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Hata2: Veri tipi uygun değil.");
                System.Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                System.Console.WriteLine("Hata3: Çok büyük veya çok büyük bir değer girdiniz.");
                System.Console.WriteLine(ex);
            }
        }
    }
}
