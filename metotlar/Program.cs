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
        }

        static int Topla(int sayi1, int sayi2){
            return sayi1+sayi2;
        }
    }
    class Metot
    {
        public void Yazdır(string str){
            Console.WriteLine(str);
        }
        public int degiskenDegistir(ref int sayi1, ref int sayi2){
            sayi1 +=10;
            sayi2 +=10;
            return sayi1+sayi2;
        }
    }
}
