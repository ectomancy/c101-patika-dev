using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Ogrenci 
    {
     private string isim;
     private string soyisim;
     private int ogrencino;
     private int sinif;
   

        public string Isim
     {
         get{return Isim; }
         set{Isim = value;}
     }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => OgrenciNo; set => OgrenciNo = value; }
        public int Sinif { get => sinif; set => sinif = value; }

        public Ogrenci(string isim,string soyisim,int ogrencino,int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrencino;
            Sinif = sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
         Console.WriteLine("ogrenci adı    :{0}", this.Isim);
         Console.WriteLine(" soyadı    :{0}", this.Soyisim);
         Console.WriteLine("No    :{0}", this.OgrenciNo);
        Console.WriteLine("ogrenci sinifi   :{0}", this.Sinif);
        }

        
    }
}