using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = Topla(5,4);
            int x=5,y=4;
            Metot metot = new Metot();
            metot.Yazdır("Toplam = "+sonuc.ToString());
            metot.Yazdır("Toplam = "+metot.degiskenDegistir(ref x, ref y).ToString());
            Console.WriteLine("x= "+x +" y= "+ y);
            string sayi = "1881";
            bool sonuc2 = int.TryParse(sayi,out int sayi1);
            Console.WriteLine(sonuc2 ? "Başarılı "+sayi1 : "Başarız");
            Carp(5,2,out int sonuc3);
            metot.Yazdır(sonuc3);  
            metot.Yazdır("patika.","Dev");
        }
        static int Topla(int sayi1, int sayi2){
            return sayi1+sayi2;
        }
        static void Carp(int sayi1, int sayi2,out int sonuc){//return kullanmadan değer döndürme
            sonuc = sayi1*sayi2;
        }
    }
    class Metot
    {
        public void Yazdır(string str){
            Console.WriteLine(str);
        }
        public void Yazdır(int str){
            Console.WriteLine(str);
        }
        public void Yazdır(string str, string str2){
            Console.WriteLine(str+str2);
        }
        public int degiskenDegistir(ref int sayi1, ref int sayi2){//degiskenin referansına ulaşarak değerini değiştirme
            sayi1 +=10;
            sayi2 +=10;
            return sayi1+sayi2;
        }
    }
}
