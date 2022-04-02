using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("lütfen bir sayı giriniz");

           int sayac = int.Parse(Console.ReadLine());
           for (int i = 1; i < sayac; i++)
           {
            if(1%2 == 1)
            Console.WriteLine(i);
           }
           int tektoplam = 0;
           int cifttoplam = 0;
           for (int i = 1; i < 1000; i++)
           {
               if(i%2 == 1)
               tektoplam += i;
               else
               cifttoplam += i;
           }
               
               Console.WriteLine("tek toplam" + tektoplam);
               Console.WriteLine("çift toplam" + cifttoplam);

               for (int i = 1; i < 10; i++)
               {
                   if(i == 4)
                   break;
               }
        } 
        
    }
}