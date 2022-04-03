using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string sayi = "999";

           bool sonuc  = int.TryParse(sayi, out int outsayi);

           if(sonuc)
           {
               Console.WriteLine("başarılı");
               Console.WriteLine(outsayi);
           }
           else
           Console.WriteLine("başarısız");

           Metotlar instance = new Metotlar();
           instance.Topla(4,5, out int toplamSonucu);
           Console.WriteLine(toplamSonucu);
        }
        class Metotlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a+b;
            }
            public void EkranaYazdır(string veri)
            {
                Console.WriteLine(veri);
            }
             public void EkranaYazdır(int veri)
            {
                Console.WriteLine(veri);
            }
        }

    }

}